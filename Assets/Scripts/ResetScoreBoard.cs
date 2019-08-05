using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResetScoreBoard : MonoBehaviour {

	// Use this for initialization
	private void ResetScore() {
        PlayerPrefs.SetFloat("highscoreScore1", 11.123456f);
        PlayerPrefs.SetFloat("highscoreScore2", 12.123456f);
        PlayerPrefs.SetFloat("highscoreScore3", 13.123456f);
        PlayerPrefs.SetFloat("highscoreScore4", 14.123456f);
        PlayerPrefs.SetFloat("highscoreScore5", 15.123456f);

        PlayerPrefs.SetString("highscoreName1", "Davie CPU");
        PlayerPrefs.SetString("highscoreName2", "Lauren CPU");
        PlayerPrefs.SetString("highscoreName3", "Emily CPU");
        PlayerPrefs.SetString("highscoreName4", "Sophia CPU");
        PlayerPrefs.SetString("highscoreName5", "Ivy CPU");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            ResetScore();
        }

        // set defaults if no score present
        if (!PlayerPrefs.HasKey("highscoreName1"))
        {
            Debug.Log("highscore not initialised");
            ResetScore();
        }

        //if (Input.GetKeyDown(KeyCode.F1))
        //{
        //    PlayerPrefs.DeleteAll();
        //    //ResetScore();
        //}

    }
}
