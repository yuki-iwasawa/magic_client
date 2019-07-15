using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Entity_Card : ScriptableObject
{	
	public List<Sheet> sheets = new List<Sheet> ();

	[System.SerializableAttribute]
	public class Sheet
	{
		public string name = string.Empty;
		public List<Param> list = new List<Param>();
	}

	[System.SerializableAttribute]
	public class Param
	{
		
		public string type;
		public string name;
		public double attack;
		public double defense;
		public double use_mana;
		public double price;
		public double element;
		public string effect;
		public string description;
	}
}

