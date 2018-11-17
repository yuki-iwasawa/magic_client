using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ChatSendScript : MonoBehaviour
{
    // Chat用のテキスト
    private string chatMessage = string.Empty;
    private InputField chatInput;

    public void OnClickButton()
    {
        StartCoroutine(ChatSend());
    }

    private IEnumerator ChatSend()
    {
        // 入力された値を取得
        chatInput = ChatInputScript.getChatInputField();
        chatMessage = chatInput.text;

        // Chatテキスト追加
        ChatViewScript chatView = new ChatViewScript();
        chatView.addChatMessage(chatMessage);

        Debug.Log("チャット送信: " + chatMessage);

        ChatInputScript.InitInputField();

        yield return true;
    }

}