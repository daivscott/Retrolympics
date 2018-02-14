using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {
    public bool levelComplete;
    public string highscorePos;
    public float score;
    public float temp;

    void Start()
    {
        score = 0;
        
    }

    void OnLevelComplete()
    {
        levelComplete = true;
        score = PlayerPrefs.GetFloat("CurrentScore");
        for (int i = 1; i <= 5; i++) //for top 5 highscores
        {
            if (PlayerPrefs.GetFloat("highscorePos" + i) > score)     //if current score is in top 5
            {
                temp = PlayerPrefs.GetFloat("highscorePos" + i);     //store the old highscore in temp varible to shift it down 
                PlayerPrefs.SetFloat("highscorePos" + i, score);     //store the currentscore to highscore position in loop
                score = temp;                                        //set score to temp(old score) to be checked through rest of loop
            }
        }
    }

    void OnGUI()
    {
        if (levelComplete)
        {
            for (int i = 1; i <= 5; i++)
            {
                GUI.Box(new Rect(100, 75 * i, 150, 50), "Pos " + i + ". " + PlayerPrefs.GetFloat("highscorePos" + i));
            }
        }
    }
}
