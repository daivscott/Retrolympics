using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetUserName : MonoBehaviour {

    public string userName;
    public InputField inputField;
    public Canvas nameCanvas;
    public Canvas mainCanvas;
    
    public void Awake()
    {
        PlayerPrefs.SetString("currentPlayerName", "NULL");
    }
    
    public void SetUserName(string text)
    {
        userName = inputField.text;
        PlayerPrefs.SetString("currentPlayerName", userName);
        SwitchCanvas();
    }

    private void SwitchCanvas()
    {
        mainCanvas.gameObject.SetActive(true);
        nameCanvas.gameObject.SetActive(false);
        //Debug.Log("userName = " + PlayerPrefs.GetString("currentPlayerName"));
    }
}
