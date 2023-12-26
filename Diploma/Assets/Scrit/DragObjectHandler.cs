using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragObjectHandler : MonoBehaviour
{
    [SerializeField] float pointsByTask;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject UI;
    [SerializeField] GameObject exit;
    [SerializeField] EcoTrigger ecoSlider;
    [SerializeField] private DragAndDrop[] dragable;

    public void CheckDragOjects()
    {
        bool Win = true;
        for (int i = 0; i < dragable.Length; i++)
        {
            if (dragable[i].Draggable == true) // если хотя бы один остается true, то есть еще не положен на место и его можно таскать, то не выиграли
            {
                Win = false;
            }
        }

        if (Win == true)
        {
            //выключаем панель, выдаем очки и т.д.
            ecoSlider.GetPowerEcoPoint(pointsByTask);
            menu.SetActive(true);
            exit.SetActive(false);
            UI.SetActive(true);
        }
    }

    private void OnEnable()
    {
        for (int i = 0; i < dragable.Length; i++)
        {
            dragable[i].Draggable = true;
            dragable[i].GetComponent<Image>().raycastTarget = true;
            dragable[i].GetComponent<RectTransform>().anchoredPosition = dragable[i].firstPosition;
            // здесь обновлять положения объектов при перезапуске панели
        }
    }
}
