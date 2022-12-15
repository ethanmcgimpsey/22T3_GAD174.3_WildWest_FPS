using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RKBackgroundMusic : MonoBehaviour
{
    public AudioClip music; // the audio clip to play

    private AudioSource audioSource; // the audio source component

    void Start()
    {
        // get the AudioSource component
        audioSource = GetComponent<AudioSource>();

        // set the audio clip
        audioSource.clip = music;

        // play the audio
        audioSource.Play();
    }
}

