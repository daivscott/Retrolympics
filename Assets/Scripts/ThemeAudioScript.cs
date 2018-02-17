using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeAudioScript : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip themeSound;
    private bool playingAudio = false;

    private void Awake()
    {
        if (!playingAudio)
        {
            audioSource = GetComponent<AudioSource>();
            AudioClip clip = themeSound;
            audioSource.PlayOneShot(clip);
            playingAudio = !playingAudio;
        }
    }
}
