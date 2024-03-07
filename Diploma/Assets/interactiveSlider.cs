using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class interactiveSlider : MonoBehaviour, IPointerUpHandler
{
    [SerializeField] Interactiv interactiv;
    [SerializeField] int sliderIndex;
    private void OnEnable()
    {
        GetComponent<Slider>().value = 0;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        interactiv.CheckSlider(sliderIndex, GetComponent<Slider>());

    }
}
