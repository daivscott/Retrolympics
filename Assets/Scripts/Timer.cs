using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{

    public Text TimerText;
    public Text CountdownText;
    public Text CountdownTextShadow;
    public Text InfoText;
    public Text InfoTextShadow;
    private float startTime;
    private float currentScore;
    private bool finished = false;
    private bool started = false;
    private bool ready = false;
    private bool countingDown = false;
    private bool textValid = false;
    private int countdown = 3;
    private int iter = 1;

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
                startCountdown();
                countingDown = true;
            }
            if (started)
            {
                startTimer();
            }
            
        }
        FontColor();
        
    }

    private void startTimer()
    {

        if (finished)
            return;

        float t = Time.time - startTime;

        currentScore = t;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f3");

        TimerText.text = "Current:  " + minutes + ":" + seconds;
    }

    private void startCountdown()
    {
        if (started)
            return;
        
        StartCoroutine(CountdownDelay());
    }

    IEnumerator CountdownDelay()
    {
        InfoText.text = "";
        InfoTextShadow.text = "";

        string seconds = countdown.ToString();
        CountdownText.text = seconds;
        CountdownTextShadow.text = seconds;
        yield return new WaitForSeconds(1);
        countdown--;

        seconds = countdown.ToString();
        CountdownText.text = seconds;
        CountdownTextShadow.text = seconds;
        yield return new WaitForSeconds(1);
        countdown--;

        seconds = countdown.ToString();
        CountdownText.text = seconds;
        CountdownTextShadow.text = seconds;
        yield return new WaitForSeconds(1);
        countdown--;

        CountdownText.text = "Go!";
        CountdownTextShadow.text = "Go!";
        started = true;
        Player.Moving();

        startTime = Time.time;
        yield return new WaitForSeconds(2);
        CountdownText.text = "";
        CountdownTextShadow.text = "";

    }

    IEnumerator ColorChangeDelay()
    {
        //Debug.Log("function works");

        while (iter < 5)
        {

            if (iter == 1)
            {
                CountdownText.color = Color.red;
                //Debug.Log("red");            
                yield return new WaitForSeconds(.05f);
                iter++;
            }

            if (iter == 2)
            {
                CountdownText.color = Color.blue;
                //Debug.Log("green");
                yield return new WaitForSeconds(.05f);
                iter++;
            }

            if (iter == 3)
            {
                CountdownText.color = Color.green;
                //Debug.Log("blue");            
                yield return new WaitForSeconds(.05f);
                iter++;
            }
            if (iter == 4)
            {
                CountdownText.color = Color.yellow;
                //Debug.Log("green");
                yield return new WaitForSeconds(.05f);
                iter = 1;
            }
        }
    }



    public void FontColor()
    {
        if (!textValid)
        {
            StartCoroutine(ColorChangeDelay());
            //ColorChangeDelay();
            textValid = true;
        }
        
    }   

    public void Finish()
    {
        finished = true;
        TimerText.color = Color.yellow;
        PlayerPrefs.SetFloat("CurrentScore", currentScore);
        //OnLevelComplete();
        GameObject.Find("Winbox").SendMessage("OnLevelComplete");
        Debug.Log("Score1 = " + PlayerPrefs.GetFloat("highscorePos1").ToString());
        Debug.Log("Score2 = " + PlayerPrefs.GetFloat("highscorePos2").ToString());
        Debug.Log("Score3 = " + PlayerPrefs.GetFloat("highscorePos3").ToString());
        Debug.Log("Score4 = " + PlayerPrefs.GetFloat("highscorePos4").ToString());
        Debug.Log("Score5 = " + PlayerPrefs.GetFloat("highscorePos5").ToString());
        Debug.Log("Current Score = " + PlayerPrefs.GetFloat("CurrentScore").ToString());
    }
}
