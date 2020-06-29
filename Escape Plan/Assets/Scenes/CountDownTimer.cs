using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 140f;
    public Text countdownText;

    void Start()
    {
        currentTime= startingTime;
    }

    void Update()
    {
        // decreases by 1 second if we don't use Time.deltaTime then it will move with one frame/sec
        currentTime -= 1 * Time.deltaTime; 
        countdownText.text= currentTime.ToString("Time Remaining"+ " "+"0");

        if(currentTime <= 20 && currentTime >=10)
            {
                countdownText.color = Color.green;
            }

        else if(currentTime < 10)
            {
                countdownText.color = Color.red;
            }

        // this will prevent time to move in negative;
        if(currentTime <= 0)
            {
               currentTime=0;
               SceneManager.LoadScene("Try Again");
        }
    }
}
