using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPlace : MonoBehaviour, IDropHandler
{
    [SerializeField] int maxCountCards;
    [SerializeField] Transform DefaultParent;

    public void OnDrop(PointerEventData eventData)
    {
        Card card = eventData.pointerDrag.GetComponent<Card>();

        if (card)
        {
            if (transform.childCount < maxCountCards)
            {
                card.defaultParent = transform;
            }
            else
            {
                transform.GetChild(0).SetParent(DefaultParent);
                card.defaultParent = transform;
            }
        }
    }
}
