using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sleepinessscale : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float pointsBySleeping;

    private Slider m_Slider;
    void Start()
    {
        m_Slider = GetComponent<Slider>();

    }
    private void OnEnable()
    {
        m_Slider.value = 1;
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
