using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {

	// Restart the game
	public void RestartGame()
    {
        SceneManager.LoadScene("200metres");
        Player.Moving();
	}

    // Return to main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Player.Moving();
    }

    // Exit the game
    public void ExitGame()
    {
        Debug.Log("Exit button pressed");
        Application.Quit();
	}
}
