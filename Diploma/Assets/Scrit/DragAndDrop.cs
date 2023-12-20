using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Color ColorDrag;
    public string slotName;
    public bool Draggable = true;
    public Vector2 lastPosition;
    public Vector2 firstPosition;

    private Color ColorMain;

    private RectTransform m_RectTransform;
    private Image image;

    private void Awake()
    {
        m_RectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        ColorMain = image.color;

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.color = ColorDrag;
        image.raycastTarget = false;
        lastPosition = GetComponent<RectTransform>().anchoredPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        m_RectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.color = ColorMain;
        image.raycastTarget = Draggable;
    }
}
