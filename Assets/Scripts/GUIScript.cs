using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScript : MonoBehaviour {

    public GameObject GUIobj;
    int counter;

	// Use this for initialization
	public void ShowHideGUIobj ()
    {
        GUIobj.SetActive(!GUIobj.activeSelf);     
    }
	
	
}
