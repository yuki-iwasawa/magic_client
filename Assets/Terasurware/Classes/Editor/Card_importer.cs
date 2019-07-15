using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;
using System.Xml.Serialization;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

public class Card_importer : AssetPostprocessor {
	private static readonly string filePath = "Assets/Resources/MasterData/Card.xls";
	private static readonly string exportPath = "Assets/Resources/MasterData/Card.asset";
	private static readonly string[] sheetNames = { "Card", };
	
	static void OnPostprocessAllAssets (string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
	{
		foreach (string asset in importedAssets) {
			if (!filePath.Equals (asset))
				continue;
				
			Entity_Card data = (Entity_Card)AssetDatabase.LoadAssetAtPath (exportPath, typeof(Entity_Card));
			if (data == null) {
				data = ScriptableObject.CreateInstance<Entity_Card> ();
				AssetDatabase.CreateAsset ((ScriptableObject)data, exportPath);
				data.hideFlags = HideFlags.NotEditable;
			}
			
			data.sheets.Clear ();
			using (FileStream stream = File.Open (filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
				IWorkbook book = null;
				if (Path.GetExtension (filePath) == ".xls") {
					book = new HSSFWorkbook(stream);
				} else {
					book = new XSSFWorkbook(stream);
				}
				
				foreach(string sheetName in sheetNames) {
					ISheet sheet = book.GetSheet(sheetName);
					if( sheet == null ) {
						Debug.LogError("[QuestData] sheet not found:" + sheetName);
						continue;
					}

					Entity_Card.Sheet s = new Entity_Card.Sheet ();
					s.name = sheetName;
				
					for (int i=1; i<= sheet.LastRowNum; i++) {
						IRow row = sheet.GetRow (i);
						ICell cell = null;
						
						Entity_Card.Param p = new Entity_Card.Param ();
						
					cell = row.GetCell(0); p.type = (cell == null ? "" : cell.StringCellValue);
					cell = row.GetCell(1); p.name = (cell == null ? "" : cell.StringCellValue);
					cell = row.GetCell(2); p.attack = (cell == null ? 0.0 : cell.NumericCellValue);
					cell = row.GetCell(3); p.defense = (cell == null ? 0.0 : cell.NumericCellValue);
					cell = row.GetCell(4); p.use_mana = (cell == null ? 0.0 : cell.NumericCellValue);
					cell = row.GetCell(5); p.price = (cell == null ? 0.0 : cell.NumericCellValue);
					cell = row.GetCell(6); p.element = (cell == null ? 0.0 : cell.NumericCellValue);
					cell = row.GetCell(7); p.effect = (cell == null ? "" : cell.StringCellValue);
					cell = row.GetCell(8); p.description = (cell == null ? "" : cell.StringCellValue);
						s.list.Add (p);
					}
					data.sheets.Add(s);
				}
			}

			ScriptableObject obj = AssetDatabase.LoadAssetAtPath (exportPath, typeof(ScriptableObject)) as ScriptableObject;
			EditorUtility.SetDirty (obj);
		}
	}
}
