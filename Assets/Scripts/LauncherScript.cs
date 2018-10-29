using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickButton() {
        StartCoroutine(Connect());
    }

    // 戻り値は仮
    private string Connect() {
        // アカウントがあったら
        // 接続確認
        Debug.Log("ログインしました。");
        return "";

        // アカウントがなかったら
        // アカウント作成画面へ

    }
}

