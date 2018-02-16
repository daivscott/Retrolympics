using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    //public bool started = false;
    public static float startTime;
    private int countdown = 3;

    public Text CountdownText;
    public Text CountdownTextShadow;
    public Text InfoText;
    public Text InfoTextShadow;

    public AudioClip three;
    public AudioClip two;
    public AudioClip one;
    public AudioClip go;
    public AudioClip gunshot;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void StartCountdown()
    {
        if (Player.started)
            return;

        StartCoroutine(CountdownDelay());
    }

    IEnumerator CountdownDelay()
    {
        InfoText.text = "";
        InfoTextShadow.text = "";

        AudioClip clip = three;
        audioSource.PlayOneShot(clip);
        string seconds = countdown.ToString();
        CountdownText.text = seconds;
        CountdownTextShadow.text = seconds;
        yield return new WaitForSeconds(1);
        countdown--;

        clip = two;
        audioSource.PlayOneShot(clip);
        seconds = countdown.ToString();
        CountdownText.text = seconds;
        CountdownTextShadow.text = seconds;
        yield return new WaitForSeconds(1);
        countdown--;

        clip = one;
        audioSource.PlayOneShot(clip);
        seconds = countdown.ToString();
        CountdownText.text = seconds;
        CountdownTextShadow.text = seconds;
        yield return new WaitForSeconds(1);
        countdown--;

        clip = go;
        audioSource.PlayOneShot(clip);
        clip = gunshot;
        audioSource.PlayOneShot(clip);
        CountdownText.text = "Go!";
        CountdownTextShadow.text = "Go!";
        Player.Started();
        Player.Moving();

        startTime = Time.time;
        yield return new WaitForSeconds(2);
        CountdownText.text = "";
        CountdownTextShadow.text = "";

    }
}
