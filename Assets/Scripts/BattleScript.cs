using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using Newtonsoft.Json;

public class BattleScript : MonoBehaviour {

    public static WebSocket ws;

    // Use this for initialization
    void Start () {
        ws = new WebSocket("ws://localhost:3000/cable");
        ws.OnOpen += (sender, e) =>
        {
            var dict = new Dictionary<string, object>();
            var identifier = new Dictionary<string, string>();
            identifier["channel"] = "BattleChannel";
            identifier["stream"] = "test";

            dict["command"] = "subscribe";
            dict["identifier"] = JsonConvert.SerializeObject(identifier); // 一度JSONにシリアライズしておく

            ws.Send(JsonConvert.SerializeObject(dict));

            Debug.Log("WebSocket Open");
        };

        ws.OnMessage += (sender, e) =>
        {

        };

        ws.OnError += (sender, e) =>
        {
            //Debug.Log("WebSocket Error Message: " + e.Message);
        };

        ws.OnClose += (sender, e) =>
        {
            Debug.Log("WebSocket Close");
        };

        ws.Connect();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
