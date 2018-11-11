using UnityEngine;
using WebSocketSharp;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Chat : MonoBehaviour
{

    WebSocket ws;

    void Start()
    {
        ws = new WebSocket("ws://localhost:3000/cable");
        ws.OnOpen += (sender, e) =>
        {
            var dict = new Dictionary<string, object>();
            var identifier = new Dictionary<string, string>();
            identifier["channel"] = "ChatChannel";

            dict["command"] = "subscribe";
            dict["identifier"] = JsonConvert.SerializeObject(identifier); // 一度JSONにシリアライズしておく

            ws.Send(JsonConvert.SerializeObject(dict));

            Debug.Log("WebSocket Open");
        };

        ws.OnMessage += (sender, e) =>
        {
            // e.Type
            Debug.Log("WebSocket Message Type: " + ", Data: " + e.Data);
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

    void Update()
    {

        if (Input.GetKeyUp("s"))
        {
            var dict = new Dictionary<string, object>();
            var identifier = new Dictionary<string, string>();
            var data = new Dictionary<string, object>();
            identifier["channel"] = "ChatChannel";

            data["action"] = "speak";
            data["message"] = "hello";

            dict["command"] = "message";
            dict["identifier"] = JsonConvert.SerializeObject(identifier); // 一度JSONにシリアライズしておく
            dict["data"] = JsonConvert.SerializeObject(data);

            ws.Send(JsonConvert.SerializeObject(dict));
        }

    }

    void OnDestroy()
    {
        ws.Close();
        ws = null;
    }
}
