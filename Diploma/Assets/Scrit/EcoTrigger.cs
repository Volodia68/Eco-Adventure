using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EcoTrigger : MonoBehaviour
{
    [SerializeField] float speed;

    
    void Start()
    {
        
    }

    
    void Update()
    {
       GetComponent<Slider>().value -= Time.deltaTime * speed;
       
    }
}
