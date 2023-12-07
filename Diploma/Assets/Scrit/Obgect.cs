using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obgect : MonoBehaviour
{
    [SerializeField] private Score score;
    private Button button;
    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Press);
    }

    private bool ispesst;

    private void OnEnable()
    {
        ispesst = false;
        button.interactable = true;
    }
    public void Press()
    {
        if (!ispesst)
        {
            ispesst = true;
            button.interactable = false;
            score.Scorecount++;
        }
    }

}
