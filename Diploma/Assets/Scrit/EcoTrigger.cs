using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;

using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;


public class EcoTrigger : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Slider ExpSlider;
    [SerializeField] float GainExp;
    public Ui ui;
    private Slider m_Slider;
    void Start()
    {
        m_Slider = GetComponent<Slider>();
    }
    
    void Update()
    {
       m_Slider.value -= Time.deltaTime * speed;

       if (m_Slider.value > 0)
       {
            ExpSlider.value += GainExp;
       }
       else if (m_Slider.value == 0)
       {
            ui.ShowLosePanel();
        }
    }
    public void GetPowerEcoPoint(float value)
    {
        m_Slider.value += value;
    }
}