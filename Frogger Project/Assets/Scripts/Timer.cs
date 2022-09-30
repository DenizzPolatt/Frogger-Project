using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Timer : MonoBehaviour
{
    float countdown = 5.0f;
    public TextMeshProUGUI timerDisplay;


    private void Start()
    {
        timerDisplay.gameObject.SetActive(true);
    }

    void Update() 
    {     
        if(countdown>0)     
        {         
            countdown -= Time.deltaTime;     
        }     
        
        double b = System.Math.Round(countdown, 0);     
        timerDisplay.text = b.ToString();    
        
        if(countdown < 0)
        {
            GameObject.Destroy(timerDisplay);  
        } 
    }
}
