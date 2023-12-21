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
    [SerializeField] EcoTrigger ecoSlider;
    [SerializeField] private FarmMoney Money;
    [SerializeField] int GainMoney;
    [SerializeField] GameObject Ui;
    public int Scorecount;
    private void Update()
    {
        text.text = Scorecount.ToString();
        if(Scorecount == 3 )
        {
            ecoSlider.GetPowerEcoPoint(pointsByTask);
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
