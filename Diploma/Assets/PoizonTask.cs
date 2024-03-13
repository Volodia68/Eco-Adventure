using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PoizonTask : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject exit;
    [SerializeField] float pointsByTask;
    public float timeRemaining = 10;
    private bool timerIsRunning = false;
    [SerializeField] private TextMeshProUGUI timeText;
    public List<CheckColor> bottle;
    private System.Random random = new System.Random();
    int t = 2;

    public void StartTimer()
    {
        
        timerIsRunning = true;
    }
    
    public void Cheking(UnityEngine.Color color)
    {
        
        if(t != 0 && color == UnityEngine.Color.red)
        {
            t--; 
        }
        else if(t == 0 )
        {
            menu.GetComponent<TaskChanger>().AddPointsToSlider(pointsByTask);
            menu.SetActive(true);
            exit.SetActive(false);
        }

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
                int count = 0;
                while (count < 3)
                {
                    int r = random.Next(0, 5);
                    if (bottle[r].color.color != UnityEngine.Color.red)
                    {
                        count++;
                        bottle[r].color.color = UnityEngine.Color.red;
                    }
                }
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
