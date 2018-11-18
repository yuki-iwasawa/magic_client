using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChatInputScript : MonoBehaviour
{

    public static InputField chatInputField;


    /// <summary>
    /// Startメソッド
    /// InputFieldコンポーネントの取得および初期化メソッドの実行
    /// </summary>
    void Start()
    {

        chatInputField = GetComponent<InputField>();

        InitInputField();
    }



    /// <summary>
    /// Log出力用メソッド
    /// 入力値を取得してLogに出力し、初期化
    /// </summary>


    public void InputLogger()
    {

        string userNameValue = chatInputField.text;

        Debug.Log(userNameValue);

        //InitInputField();
    }



    /// <summary>
    /// InputFieldの初期化用メソッド
    /// 入力値をリセットして、フィールドにフォーカスする
    /// </summary>


    public static void InitInputField()
    {

        // 値をリセット
        chatInputField.text = "";

        // フォーカス
        chatInputField.ActivateInputField();
    }


    /// <summary>
    /// Gets the input field.
    /// </summary>
    /// <returns>The input field.</returns>
    public static InputField getChatInputField()
    {
        return chatInputField;
    }

}