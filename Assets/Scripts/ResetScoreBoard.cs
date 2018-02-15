using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResetScoreBoard : MonoBehaviour {

	// Use this for initialization
	private void ResetScore() {
        PlayerPrefs.SetFloat("highscorePos1", 11.123456f);
        PlayerPrefs.SetFloat("highscorePos2", 12.123456f);
        PlayerPrefs.SetFloat("highscorePos3", 13.123456f);
        PlayerPrefs.SetFloat("highscorePos4", 14.123456f);
        PlayerPrefs.SetFloat("highscorePos5", 15.123456f);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ResetScore();
        }


    }
}
