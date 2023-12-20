using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{
    [SerializeField] private string slotName;
    [SerializeField] private DragObjectHandler dragObjectHandler;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<DragAndDrop>() != null)
            {
                if (slotName == eventData.pointerDrag.GetComponent<DragAndDrop>().slotName)
                {
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<DragAndDrop>().Draggable = false;
                    dragObjectHandler.CheckDragOjects();
                }

                else
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = eventData.pointerDrag.GetComponent<DragAndDrop>().lastPosition;

            }
        }
    }
}
