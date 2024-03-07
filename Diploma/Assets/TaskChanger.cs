using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskChanger : MonoBehaviour
{
    [SerializeField] private GameObject[] Tasks;
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
            Tasks[Random.Range(0, Tasks.Length)].SetActive(true);
        }
        else if( regionIndex == 1) 
        {
            Tasks[Random.Range(0, Tasks.Length - 1)].SetActive(true);
        }
        else if (regionIndex == 0)
        {
            Tasks[Random.Range(0, Tasks.Length - 1)].SetActive(true);
        }
    }

    public void AddPointsToSlider(float pointsByTask)
    {
        ecoSliders[currentRegion].GetPowerEcoPoint(pointsByTask);
    }
}
