using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PoizonTask : MonoBehaviour
{
    [SerializeField] private GameObject[] Bottle; 
    public float timeRemaining = 10;
    private bool timerIsRunning = false;
    [SerializeField] private TextMeshProUGUI timeText;

    public void StartTimer()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }


    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
