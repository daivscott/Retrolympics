using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winbox : MonoBehaviour {

    private AudioSource audioSource;

    public AudioClip finishSound;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Collision working");
        

        GameObject.Find("Player").SendMessage("Finish");

        //GameObject.Find("Player").SendMessage("Moving");
        Player.Moving();
        
        GameObject.Find("Main Camera").SendMessage("ShowHideGUIobj");
        AudioClip clip = finishSound;
        audioSource.PlayOneShot(clip);
    }
}
