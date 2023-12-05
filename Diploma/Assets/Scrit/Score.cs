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
    [SerializeField] EcoTrigger ecoSlider;
    public int Scorecount;
    private void Update()
    {
        text.text = Scorecount.ToString();
        if(Scorecount == 3 )
        {
            ecoSlider.GetPowerEcoPoint(Scorecount);
            menu.SetActive(true);
            exit.SetActive(false);
        }
    }
    private void OnEnable()
    {
        Scorecount = 0;
    }
}
