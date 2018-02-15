using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{

    public Text TimerText;
    private float currentScore;
    private bool finished = false;
    private bool ready = false;
    private bool countingDown = false;
    
    

    // Use this for initialization
    void Start () {
        Player.Moving();
    }

    // Update is called once per frame
    void Update () {
        if (Input.anyKey)
        {
            ready = true;
        }

        if (ready)
        {
            if (!countingDown)
            {
                GameObject.Find("Player").SendMessage("StartCountdown");                

                countingDown = true;
            }

            if (Player.started)
            {
                startTimer();
            }
            
        }       
        
    }

    private void startTimer()
    {

        if (finished)
            return;

        float t = Time.time - Countdown.startTime;

        currentScore = t;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f3");

        TimerText.text = "Current:  " + minutes + ":" + seconds;
    }

    public void Finish()
    {
        finished = true;
        TimerText.color = Color.yellow;
        Player.Started();
        PlayerPrefs.SetFloat("CurrentScore", currentScore);
        
        GameObject.Find("Winbox").SendMessage("OnLevelComplete");
        
    }
}
