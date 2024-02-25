using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float pointsByTask;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject exit;
    [SerializeField] GameObject Ui;

    private Slider m_Slider;
    private void AddEcolog()
    {
        if (m_Slider.value == m_Slider.maxValue)
        {
            menu.GetComponent<TaskChanger>().AddPointsToSlider(pointsByTask);
            Ui.SetActive(true);
            menu.SetActive(true);
            exit.SetActive(false);
        }
    }
    
    void Awake()
    {
        m_Slider = GetComponent<Slider>();
        m_Slider.onValueChanged.AddListener(delegate { AddEcolog(); });
    }

    private void OnEnable()
    {
        m_Slider.value = 0;
    }
    void Update()
    {
        m_Slider.value -= Time.deltaTime * speed;
       
    }
    public void Plusloding(float count)
    {
        m_Slider.value += count;
    }
}
