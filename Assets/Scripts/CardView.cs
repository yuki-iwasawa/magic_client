using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{

    [SerializeField] private Text cardNameText;
    [SerializeField] private Text cardEffectText;

    //private MstCards.Card cardData;

    /// <summary>
    /// Instantiate the specified cardData.
    /// </summary>
    public void Instantiate(CardView prefab, Transform parent)
    {
        //インスタンス化
        //CardView item = Instantiate(prefab, parent).GetComponent<CardView>();
        //初期値設定
        //item.cardData = cardData;
        //表示
        //item.Print();
    }

    /// <summary>
    /// 自身(カード)を拡大して表示する
    /// </summary>
    public void Zoom()
    {
        //省略
    }

    /// <summary>
    /// カード情報を表示する
    /// </summary>
    public void Print()
    {
        //cardNameText.text = this.name;
        //cardEffectText.text = this.effect;
    }
}