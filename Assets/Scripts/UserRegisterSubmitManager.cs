using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class UserRegisterSubmitManager : MonoBehaviour {

    public static UnityWebRequest request;

    public void OnClickButton() {
            StartCoroutine(Connect());
    }

    private IEnumerator Connect() {

        InputField userNameField = UserRegisterInputManager.getUserNameField(); // ログイン画面の入力フォーム情報取得
        string userName = userNameField.text; //入力されたユーザ名を格納

        // ユーザ作成API
        request = UnityWebRequest.Get("http://localhost:3000/users/register1"); 
        request.SetRequestHeader("name", userName);
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

    public static string getUserName()
    {
        return request.downloadHandler.text;
    }

    public static string getUserCode()
    {
        return request.downloadHandler.text;
    }
}