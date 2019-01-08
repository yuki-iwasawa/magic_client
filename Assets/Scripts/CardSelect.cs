using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardSelect : MonoBehaviour, IPointerEnterHandler
{
    private RectTransform rect;

    public Vector2 TopRight;
    public Vector2 TopLeft;
    public Vector2 BottomLeft;
    public Vector2 BottomRight;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnPointerEnter");

        rect = gameObject.GetComponent<RectTransform>();

        var offsetMax = rect.offsetMax;
        var offsetMin = rect.offsetMin;

        TopRight = new Vector2(Screen.width + offsetMax.x, Screen.height + offsetMax.y);
        TopLeft = new Vector2(offsetMin.x, Screen.height + offsetMax.y);
        BottomLeft = new Vector2(offsetMin.x, offsetMin.y);
        BottomRight = new Vector2(Screen.width + offsetMax.x, offsetMin.y);
    }
}
