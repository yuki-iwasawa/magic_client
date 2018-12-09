//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CardView : MonoBehaviour
//{

//    [SerializeField] private TextMeshProUGUI cardNameText;
//    [SerializeField] private TextMeshProUGUI cardEffectText;

//    private MstCards.Card cardData;

//    /// <summary>
//    /// Instantiate the specified cardData.
//    /// </summary>
//    /// <param name="cardData">Card data.</param>
//    public void Instantiate(CardView prefab, Transform parent, MstCards.Card cardData)
//    {
//        //インスタンス化
//        CardView item = Instantiate(prefab, parent).GetComponent<CardView>();
//        //初期値設定
//        item.cardData = cardData;
//        //表示
//        item.Print();
//    }

//    /// <summary>
//    /// 自身(カード)を拡大して表示する
//    /// </summary>
//    public void Zoom()
//    {
//        //省略
//    }

//    /// <summary>
//    /// カード情報を表示する
//    /// </summary>
//    public void Print()
//    {
//        cardNameText.text = this.cardData.name;
//        cardEffectText.text = this.cardData.effect;
//    }
//}