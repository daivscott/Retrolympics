using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winbox : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Collision working");
        
        GameObject.Find("Player").SendMessage("Finish");

        //GameObject.Find("Player").SendMessage("Moving");
        Player.Moving();
    }
}
