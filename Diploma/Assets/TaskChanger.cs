using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskChanger : MonoBehaviour
{
    [SerializeField] private GameObject[] TasksCity, TasksRiver, TasksForest;

    [SerializeField] private EcoTrigger[] ecoSliders;
    [SerializeField] private GameObject Map, Garage, UI;


    private int currentRegion;

    public void ChooseTask(int regionIndex)
    {
        Map.SetActive(false);
        Garage.SetActive(false);
        UI.SetActive(false);

        currentRegion = regionIndex;

        if( regionIndex == 2)
        {
            TasksCity[Random.Range(0, TasksCity.Length)].SetActive(true);
        }
        else if( regionIndex == 1) 
        {
            TasksRiver[Random.Range(0, TasksRiver.Length)].SetActive(true);
        }
        else if (regionIndex == 0)
        {
            TasksForest[Random.Range(0, TasksForest.Length)].SetActive(true);
        }
    }
    public void AddPointsToSlider(float pointsByTask)
    {
        ecoSliders[currentRegion].GetPowerEcoPoint(pointsByTask);
    }
}
