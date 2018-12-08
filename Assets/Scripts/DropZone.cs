using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler{

    //public CardDrag.Slot typeOfCard = CardDrag.Slot.Attack;

    public void OnPointerEnter(PointerEventData eventData) {
        //Debug.Log("OnPointerEnter");
        if (eventData.pointerDrag == null)
            return;
        CardDrag d = eventData.pointerDrag.GetComponent<CardDrag>();
        if (d != null) {
            d.placeholderParent = this.transform;
        }
    }

    public void OnPointerExit(PointerEventData eventData) {
        //Debug.Log("OnPointerExit");
        if (eventData.pointerDrag == null)
            return;
        CardDrag d = eventData.pointerDrag.GetComponent<CardDrag>();
        if (d != null && d.placeholderParent == this.transform)
        {
            d.placeholderParent = d.parentToReturnTo;
        }
    }

    public void OnDrop(PointerEventData eventData){
        Debug.Log(eventData.pointerDrag.name + "was dropped on " + gameObject.name);

        CardDrag d = eventData.pointerDrag.GetComponent<CardDrag>();
        if (d != null) {
            d.parentToReturnTo = this.transform;
        }
    }
}
