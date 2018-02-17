using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    public Canvas nameCanvas;
    public Canvas mainCanvas;
    public InputField inputField;
    public bool levelComplete;
    public string highscorePos;
    public float winScore;
    public string winName;
    public float tempScore;
    public string tempName;
    private string userName;
    private float currentScore;
    private bool nameEntry = false;
    private bool winner = false;
    private bool winnerSoundPlayed = false;

    private AudioSource audioSource;
    public AudioClip won;
    public AudioClip lost;

    public void Awake()
    {
        winScore = 0;
        winName = "NULL";
        audioSource = GetComponent<AudioSource>();
    }

    IEnumerator OnLevelComplete()
    {
        levelComplete = true;
        winScore = PlayerPrefs.GetFloat("CurrentScore");
        
        for (int i = 1; i <= 5; i++) //loop to store/check through the top 5 highscores
        {
            if (PlayerPrefs.GetFloat("highscoreScore" + i) > winScore)     //if current score is in top 5
            {
                winner = !winner;
                raceOutcome();
                mainCanvas.gameObject.SetActive(false);
                nameCanvas.gameObject.SetActive(true);
                StartCoroutine(PauseTyping());
                //inputField.Select();                

                if (!nameEntry)
                {
                    while (winName == "NULL")
                    {
                        yield return null;
                        winName = PlayerPrefs.GetString("currentPlayerName");
                        
                    }
                    nameCanvas.gameObject.SetActive(false);
                    mainCanvas.gameObject.SetActive(true);
                    GameObject.Find("Scoreboard").SendMessage("ShowHideGUIobj");
                }
                //Debug.Log("still going");
                
                
                    GameObject.Find("Scoreboard").SendMessage("ShowHideGUIobj");
                    tempScore = PlayerPrefs.GetFloat("highscoreScore" + i);     //store the old highscore in temp varible to shift it down 
                    tempName = PlayerPrefs.GetString("highscoreName" + i);
                    PlayerPrefs.SetFloat("highscoreScore" + i, winScore);     //store the currentscore to highscore position in loop
                    PlayerPrefs.SetString("highscoreName" + i, winName);
                    winScore = tempScore;                                        //set score to temp(old score) to be checked through rest of loop
                    winName = tempName;
                nameEntry = false;
                
                
            }
            
        }
        raceOutcome();
        //inputField.Select();
    }

    private void raceOutcome()
    {
        if (winner && !winnerSoundPlayed)
        {
            AudioClip clip = won;
            audioSource.PlayOneShot(clip);
            winnerSoundPlayed = !winnerSoundPlayed;
        }
        if (!winner && !winnerSoundPlayed)
        {
            AudioClip clip = lost;
            audioSource.PlayOneShot(clip);
        }
    }

    IEnumerator PauseTyping()
    {
        //Debug.Log("1");
        yield return new WaitForSeconds(1);
        inputField.Select();
        //Debug.Log("2");
    }

    /*void OnGUI()
    {
        if (levelComplete)
        {
            for (int i = 1; i <= 5; i++)
            {
                GUI.Box(new Rect(100, 75 * i, 150, 50), PlayerPrefs.GetString("highscoreName" + i) + " = " + PlayerPrefs.GetFloat("highscoreScore" + i));
            }
        }
    }*/
}
