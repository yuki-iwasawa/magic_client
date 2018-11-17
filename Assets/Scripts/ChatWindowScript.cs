using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChatWindowScript : MonoBehaviour
{
    // メッセージを管理するリスト
    private List<string> messages = new List<string>();
    // Chat用のテキスト
    private string currentMessage = string.Empty;
    public int layer;
    public GUIStyleState styleState;
    private GUIStyle style;

    private void OnGUI()
    {
        GUILayout.Space(20);
        GUI.depth = layer;

        // Chat欄の生成
        GUILayout.BeginHorizontal();

        var rect1 = new Rect(20, 100, 800, 200);
        GUI.Window(0, rect1, DoMyWindow, "Chat");
        //createMessage(messages);

        GUILayout.EndHorizontal();


        //// Chat入力欄の生成
        //GUILayout.BeginHorizontal();

        //// 入力情報取得
        //currentMessage = GUI.TextField(new Rect(20, 275, 750, 25), currentMessage);

        //// Sendボタン
        //if (GUI.Button(new Rect(770, 275, 50, 25), "Send", "button"))
        //{
        //    // 入力が空ではない場合処理
        //    if (!string.IsNullOrEmpty(currentMessage.Trim()))
        //    {
        //        Debug.Log(currentMessage);
        //        messages.Add(currentMessage);

        //        // 送信後は、入力値を空
        //        currentMessage = string.Empty;
        //    }
        //}

        //GUILayout.EndHorizontal();


    }

    private void createMessage(List<string> messages)
    {
        // 入力されたメッセージを逆順に表示
        for (int i = 0; i < messages.Count; i++)
        {
            styleState = new GUIStyleState();
            style = new GUIStyle();

            styleState.textColor = Color.red;
            style.normal = styleState;

            GUI.Label(new Rect(20, 150, 800, 200), "iwasawa: " + messages[i], style);
        }
    }

    void DoMyWindow(int windowID)
    {
    }
}