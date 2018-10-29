using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SubmitManager : MonoBehaviour {

    public void OnClickButton() {
            StartCoroutine(Connect());
    }

    private IEnumerator Connect() {

        InputField x = InputManager.getInputField(); // ログイン画面の入力フォーム情報取得
        string user_name = x.text; //入力されたユーザ名を格納

        // ユーザ作成API
        UnityWebRequest request = UnityWebRequest.Get("http://~~"); 
        request.SetRequestHeader("name", user_name);
        yield return request.SendWebRequest();

        if (request.error == null)
        {
            Debug.Log("request Submit Ok!: " + request.responseCode.ToString() + request.downloadHandler.text);
        }
        else
        {
            Debug.Log("request Submit Error: " + request.responseCode.ToString() + request.error);
        }

    }
}