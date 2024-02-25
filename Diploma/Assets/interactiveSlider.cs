using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class interactiveSlider : MonoBehaviour
{
    [SerializeField] Interactiv interactiv;
    [SerializeField] int sliderIndex;

    public void OnPointerUp(PointerEventData eventData)
    {
        interactiv.CheckSlider(sliderIndex, GetComponent<Slider>());
    }
}
