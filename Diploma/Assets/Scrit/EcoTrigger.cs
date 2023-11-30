using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EcoTrigger : MonoBehaviour
{
    [SerializeField] float speed;

    private Slider m_Slider;
    void Start()
    {
        m_Slider = GetComponent<Slider>();
    }
    

    void Update()
    {
       m_Slider.value -= Time.deltaTime * speed;
       if(m_Slider.value == 0)
       {

       }
    }
}
