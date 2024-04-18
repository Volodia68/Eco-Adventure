using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckColor : MonoBehaviour
{
    public Image color;
    public Button Bottle;
    public PoizonTask NamingIvante;
    private void Awake()
    {
        Bottle.onClick.AddListener(Cheking);
        Bottle.onClick.AddListener(() => NamingIvante.Cheking(color.color));
    }

    private void Cheking()
    {
        if (color.color == Color.red)
        {
            Bottle.interactable = false;
        } 
    }
}
