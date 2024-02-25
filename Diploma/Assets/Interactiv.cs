using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Unity.VisualScripting;

public class Interactiv : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject exit;
    [SerializeField] float pointsByTask;
    [SerializeField] Slider[] slidersBack;
    [SerializeField] float tolerance;

    private float[] slidersValue;

    private void OnEnable()
    {
        slidersValue = new float[slidersBack.Length];

        for (int i = 0; i < slidersBack.Length; i++)
        {
            slidersBack[i].value = Random.Range(0.1f, 1.0f);
            slidersValue[i] = 0;
        }
    }


    public void CheckSlider(int sliderIndex, Slider currentSlider)
    {
        //Debug.Log("Slider" + sliderIndex + " value: " + currentSlider.value);

        slidersValue[sliderIndex] = currentSlider.value;

        bool win = true;

        for (int i = 0; i < slidersValue.Length; i++)
        {
            if (slidersValue[i] < slidersBack[i].value - tolerance || slidersValue[i] > slidersBack[i].value + tolerance)
            {
                win = false;
            }
        }

        if (win)
        {
            // даем очки, выключаем задание и т.д.
            menu.GetComponent<TaskChanger>().AddPointsToSlider(pointsByTask);
            menu.SetActive(true);
            exit.SetActive(false);
        }
        Debug.Log(win);
    }
}
