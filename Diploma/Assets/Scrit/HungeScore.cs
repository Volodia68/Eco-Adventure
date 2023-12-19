using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungeScore : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float pointsByEating;
    

    private Slider m_Slider;

    void Awake()
    {
        m_Slider = GetComponent<Slider>();

    }

    private void OnEnable()
    {
        m_Slider.value = 1;
    }

    void Start()
    {
        
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
