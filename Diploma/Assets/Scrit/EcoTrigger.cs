using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;


public class EcoTrigger : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Slider ExpSlider;
    [SerializeField] float GainExp;
    [SerializeField] GameObject lose;
    [SerializeField] private FarmMoney score;

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
            score.ScoreMoney++;


       }
       else if (m_Slider.value == 0)
       {
            lose.SetActive(true);
       }
    }
    public void GetPowerEcoPoint(float value)
    {
        m_Slider.value += value;
    }
}