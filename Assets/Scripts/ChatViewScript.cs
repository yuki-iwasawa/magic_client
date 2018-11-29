using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using WebSocketSharp;
using Newtonsoft.Json;
using System.Linq;

public class ChatViewScript : MonoBehaviour
{
    //// メッセージを管理するリスト
    public static List<string> messages = new List<string>();
    private ScrollRect scrollRect;
    public Text textLog;
    public static WebSocket ws;

    void Start()
    {
        ws = new WebSocket("ws://localhost:3000/cable");
        ws.OnOpen += (sender, e) =>
        {
            var dict = new Dictionary<string, object>();
            var identifier = new Dictionary<string, string>();
            identifier["channel"] = "ChatChannel";
            identifier["stream"] = "Test";

            dict["command"] = "subscribe";
            dict["identifier"] = JsonConvert.SerializeObject(identifier); // 一度JSONにシリアライズしておく

            ws.Send(JsonConvert.SerializeObject(dict));

            Debug.Log("WebSocket Open");
        };

        ws.OnMessage += (sender, e) =>
        {
            var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(e.Data);

            if (data.ContainsKey("type") && data["type"] == "chat")
            {
                messages.Add(data["message"]);
                Debug.Log("on Message:" + e.Data);
            }

        };

        ws.OnError += (sender, e) =>
        {
            Debug.Log("WebSocket Error Message: " + e.Message);
        };

        ws.OnClose += (sender, e) =>
        {
            Debug.Log("WebSocket Close");
        };

        ws.Connect();

    }

    private void OnGUI()
    {
        scrollRect = GetComponentInParent<ScrollRect>();
        textLog = GetComponentInChildren<Text>();

        foreach (string message in messages)
        {
            textLog.text += (message + "\n");
            scrollRect.verticalNormalizedPosition = 0;
        }
        messages = new List<string>();
    }

    public void addChatMessage(string chatMessages)
    {
        messages.Add(chatMessages);

        var dict = new Dictionary<string, object>();
        var identifier = new Dictionary<string, string>();
        var data = new Dictionary<string, object>();

        identifier["channel"] = "ChatChannel";
        identifier["stream"] = "Test";

        data["action"] = "speak";
        data["message"] = chatMessages;

        dict["command"] = "message";
        dict["type"] = "chat";
        dict["identifier"] = JsonConvert.SerializeObject(identifier); // 一度JSONにシリアライズしておく
        dict["data"] = JsonConvert.SerializeObject(data);

        ws.Send(JsonConvert.SerializeObject(dict));
    }



    void DoMyWindow(int windowID)
    {
    }
}