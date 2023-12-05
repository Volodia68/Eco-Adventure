using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obgect : MonoBehaviour
{
    [SerializeField] private Score score;
    private void Awake()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(Press);
    }

    private bool ispesst;

    public void Press()
    {
        if (!ispesst)
        {
            ispesst = true;
            score.Scorecount++;
        }
    }

}
