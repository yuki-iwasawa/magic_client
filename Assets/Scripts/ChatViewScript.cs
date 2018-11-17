using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ChatViewScript : MonoBehaviour
{
    //// メッセージを管理するリスト
    public static List<string> messages = new List<string>();
    // Chat用のテキスト
    //private string currentMessage = string.Empty;
    //public int layer;
    //public GUIStyleState styleState;
    //private GUIStyle style;

    // ScrollViewのScrollRect
    //private ScrollRect scrollRect;
    // ScrollViewのText
    public Text textLog;

    private void OnGUI()
    {
        //scrollRect = GetComponentInParent<ScrollRect>();
        textLog = GetComponentInChildren<Text>();

        foreach (string message in messages)
        {
            textLog.text += (message + "\n");
        }
        messages = new List<string>();
        //createMessage(messages);

        //// Chat入力欄の生成
        //GUILayout.BeginHorizontal();

        //// 入力情報取得
        //currentMessage = GUI.TextField(new Rect(5, 200, 100, 50), currentMessage);

        //// Sendボタン
        //if (GUI.Button(new Rect(105, 120, 50, 25), "Send", "button"))
        //{
        //    // 入力が空ではない場合処理
        //    if (!string.IsNullOrEmpty(currentMessage.Trim()))
        //    {
        //        Debug.Log(currentMessage);
        //        createMessage(currentMessage);
        //        scrollRect.verticalNormalizedPosition = 0;

        //        // 送信後は、入力値を空
        //        currentMessage = string.Empty;
        //    }
        //}

        //GUILayout.EndHorizontal();


    }

    public void addChatMessage(string chatMessages)
    {
        messages.Add(chatMessages);
    }

    void DoMyWindow(int windowID)
    {
    }
}