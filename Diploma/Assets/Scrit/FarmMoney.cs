using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FarmMoney : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI text;
    private int ScoreMoney;
    public void AddMoney(int value)
    {
        ScoreMoney += value;
        text.text = ScoreMoney.ToString();
    }
    
}
