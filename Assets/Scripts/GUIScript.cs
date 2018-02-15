using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScript : MonoBehaviour {

    public GameObject RestartBtn;
    public GameObject MainMenuBtn;
    //int counter;

    // Show/Hide Button
    public void ShowHideGUIobj ()
    {
        RestartBtn.SetActive(!RestartBtn.activeSelf);
        MainMenuBtn.SetActive(!MainMenuBtn.activeSelf);
    }
	
	
}
