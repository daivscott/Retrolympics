using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {

	// Use this for initialization
	public void RestartGame()
    {
        SceneManager.LoadScene("200metres");
        Player.Moving();
	}
	
	// Update is called once per frame
	public void ExitGame()
    {
        Debug.Log("Exit button pressed");
        Application.Quit();
	}
}
