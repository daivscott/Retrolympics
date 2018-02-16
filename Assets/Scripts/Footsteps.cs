using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {

    public AudioClip[] leftClips;
    public AudioClip[] rightClips;

    private AudioSource audioSource;
    private float VolumeSlider = 0.1f;
    private bool leftFoot;
    

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Step()
    {
        audioSource.volume = VolumeSlider;
        AudioClip clip = GetRandomClip();
        audioSource.PlayOneShot(clip);
    }

    private AudioClip GetRandomClip()
    {
        if (!leftFoot)
        {
            leftFoot = !leftFoot;
            return leftClips[UnityEngine.Random.Range(0, leftClips.Length)];            
        }
        else
        {
            leftFoot = !leftFoot;
            return rightClips[UnityEngine.Random.Range(0, rightClips.Length)];
        }
    }
}
