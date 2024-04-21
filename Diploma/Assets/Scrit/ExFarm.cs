using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExFarm : MonoBehaviour
{

    public Ui ui;

    private Slider m_Slider;
    void Start()
    {
        m_Slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Slider.value == 1)
        {
            ui.ShowWinPanel();

        }
    }
}
