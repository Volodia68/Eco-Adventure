using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskChanger : MonoBehaviour
{
    [SerializeField] private GameObject[] Tasks;
    [SerializeField] private GameObject Map, Garage, UI;
    public void ChooseTask()
    {
        Map.SetActive(false);
        Garage.SetActive(false);
        UI.SetActive(false);

        Tasks[Random.Range(0, Tasks.Length)].SetActive(true);
    }

}
