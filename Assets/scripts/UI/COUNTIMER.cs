using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class COUNTIMER : MonoBehaviour
{
    public float startTime;
    public float currentTime;
    public Text timerText;

    void Awake()
    {
        currentTime = startTime;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime =  currentTime -Time.deltaTime;
        }
        else
        {
            currentTime = 0;
        }

        int minutes = (int)(currentTime / 60); 
        int seconds = (int)Mathf.Ceil(currentTime % 60);
        if(seconds > 10)
        {
            timerText.text = minutes + ": " + seconds;
        }
        else
        {
            timerText.text = minutes + ": 0" + seconds;
        }
        
    }
}
