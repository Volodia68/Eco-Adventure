using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject exit;
    [SerializeField] float pointsByTask;
    [SerializeField] private FarmMoney Money;
    [SerializeField] int GainMoney;
    [SerializeField] GameObject Ui;
    public int Scorecount;
    private void Update()
    {
        text.text = Scorecount.ToString();
        if(Scorecount == 3 )
        {
            menu.GetComponent<TaskChanger>().AddPointsToSlider(pointsByTask);
            Ui.SetActive(true);
            menu.SetActive(true);
            exit.SetActive(false);
            Money.AddMoney(GainMoney);
        }
    }
    private void OnEnable()
    {
        Scorecount = 0;
    }
}
