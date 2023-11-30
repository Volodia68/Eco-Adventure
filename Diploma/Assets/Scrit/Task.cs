using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float speed;

    private Slider m_Slider;
    void Start()
    {
        m_Slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        m_Slider.value = 0;
    }
    void Update()
    {
        //m_Slider.value += Time.deltaTime * speed;
        if (m_Slider.value == m_Slider.maxValue)
        {

        }
    }
    public void PlusEco(float count)
    {
        m_Slider.value += count;
    }
}
