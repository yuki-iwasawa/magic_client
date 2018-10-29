﻿using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class InputManager : MonoBehaviour
{

    public static InputField inputField;


    /// <summary>
    /// Startメソッド
    /// InputFieldコンポーネントの取得および初期化メソッドの実行
    /// </summary>
    void Start()
    {

        inputField = GetComponent<InputField>();

        InitInputField();
    }



    /// <summary>
    /// Log出力用メソッド
    /// 入力値を取得してLogに出力し、初期化
    /// </summary>


    public void InputLogger()
    {

        string inputValue = inputField.text;

        Debug.Log(inputValue);

        //InitInputField();
    }



    /// <summary>
    /// InputFieldの初期化用メソッド
    /// 入力値をリセットして、フィールドにフォーカスする
    /// </summary>


    void InitInputField()
    {

        // 値をリセット
        inputField.text = "";

        // フォーカス
        inputField.ActivateInputField();
    }


    /// <summary>
    /// Gets the input field.
    /// </summary>
    /// <returns>The input field.</returns>
    public static InputField getInputField() {
        return inputField;
    }

}