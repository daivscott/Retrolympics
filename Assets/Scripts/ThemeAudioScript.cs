using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeAudioScript : MonoBehaviour {

    //private AudioSource audioSource;
    //public AudioClip themeSound;
    private bool playingAudio = false;
    public static ThemeAudioScript sin;

    private void Awake()
    {
        if (sin == null)
            sin = this;
        else if (sin != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        
        /*if (playingAudio)
        {
            audioSource = GetComponent<AudioSource>();
            AudioClip clip = themeSound;
            audioSource.PlayOneShot(clip);
            //playingAudio = !playingAudio;
        }*/
    }
    void Start()
    {
        //if (playingAudio == false)
        //{
        //    AudioSource audio = GetComponent<AudioSource>();
        //    audio.Play();
        //    playingAudio = true;
        //}
    }
}
