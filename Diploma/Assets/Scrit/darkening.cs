using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class darkening : MonoBehaviour
{

    
    public float fade_speed = 1f;
    public float nightDuration; 

    private float currentTimer;
    private bool toBlack = true;
    private Image fade_image;
    private void Start()
    {
        fade_image = GetComponent<Image>();
    }
    private void OnEnable()
    {
        toBlack = true;
    }
    void Update()
    {
        
        Color color = fade_image.color;
        if (color.a < 1f && toBlack)
        {
            color.a += fade_speed * Time.deltaTime;
            fade_image.color = color;
            currentTimer = nightDuration;

        }
        else if (color.a > 0f && !toBlack)
        {
            color.a -= fade_speed * Time.deltaTime;
            fade_image.color = color;
            if(color.a <= 0)
            {
                gameObject.SetActive(false);
            }

        }
        else if (color.a >= 1f && toBlack)
        {
            currentTimer -= Time.deltaTime;
            if(currentTimer <= 0)
            {
                toBlack = false;
            }
        }

    }
}
