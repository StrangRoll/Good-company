using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Camera mainCamera;
    Vector3 offset;
    [HideInInspector] public Transform defaultParent;
    [SerializeField] private Transform megaParent;

    void Awake()
    {
        mainCamera = Camera.main;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        offset = transform.position - mainCamera.ScreenToWorldPoint(eventData.position);
        defaultParent = transform.parent;
        transform.SetParent(megaParent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 newPos = mainCamera.ScreenToWorldPoint(eventData.position);
        newPos.z = 0;
        transform.position = newPos + offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        transform.SetParent(defaultParent);
        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }
}
