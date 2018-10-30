using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class UserRegisterInputManager : MonoBehaviour
{

    public static InputField userNameField;


    /// <summary>
    /// Startメソッド
    /// InputFieldコンポーネントの取得および初期化メソッドの実行
    /// </summary>
    void Start()
    {

        userNameField = GetComponent<InputField>();

        InitInputField();
    }



    /// <summary>
    /// Log出力用メソッド
    /// 入力値を取得してLogに出力し、初期化
    /// </summary>


    public void InputLogger()
    {

        string userNameValue = userNameField.text;

        Debug.Log(userNameValue);

        //InitInputField();
    }



    /// <summary>
    /// InputFieldの初期化用メソッド
    /// 入力値をリセットして、フィールドにフォーカスする
    /// </summary>


    void InitInputField()
    {

        // 値をリセット
        userNameField.text = "";

        // フォーカス
        userNameField.ActivateInputField();
    }


    /// <summary>
    /// Gets the input field.
    /// </summary>
    /// <returns>The input field.</returns>
    public static InputField getUserNameField() {
        return userNameField;
    }

}