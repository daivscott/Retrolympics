using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {

	// Restart the game
	public void RestartGame()
    {
        SceneManager.LoadScene("200metres");
        if(Player.isMoving = true)
        {
            Player.Moving();
        }
        
	}

    // Return to main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        if (Player.isMoving = true)
        {
            Player.Moving();
        }
    }

    // Show the scoreboard
    public void Scoreboard()
    {
        SceneManager.LoadScene("Scoreboard");
        //Player.Moving();
    }

    // Exit the game
    public void ExitGame()
    {
        Debug.Log("Exit button pressed");
        Application.Quit();
	}
}
