using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateScoreboard : MonoBehaviour {

    public Text UserName1;
    public Text Time1;
    public Text UserName2;
    public Text Time2;
    public Text UserName3;
    public Text Time3;
    public Text UserName4;
    public Text Time4;
    public Text UserName5;
    public Text Time5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        UserName1.text = PlayerPrefs.GetString("highscoreName1");
        Time1.text = PlayerPrefs.GetFloat("highscoreScore1").ToString();

        UserName2.text = PlayerPrefs.GetString("highscoreName2");
        Time2.text = PlayerPrefs.GetFloat("highscoreScore2").ToString();

        UserName3.text = PlayerPrefs.GetString("highscoreName3");
        Time3.text = PlayerPrefs.GetFloat("highscoreScore3").ToString();

        UserName4.text = PlayerPrefs.GetString("highscoreName4");
        Time4.text = PlayerPrefs.GetFloat("highscoreScore4").ToString();

        UserName5.text = PlayerPrefs.GetString("highscoreName5");
        Time5.text = PlayerPrefs.GetFloat("highscoreScore5").ToString();

    }
}
