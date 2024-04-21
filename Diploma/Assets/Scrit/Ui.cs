using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui : MonoBehaviour
{
    public GameObject winpanel;

    public GameObject losepanel;
    private bool IsWin;
    private bool IsLose;
    public void ShowWinPanel()
    {
        if (IsLose == true) return;
        winpanel.SetActive(true);
        IsWin = true;
    }
    public void ShowLosePanel()
    {
        if (IsWin == true) return;
        losepanel.SetActive(true);
        IsLose = true;
    }

}
