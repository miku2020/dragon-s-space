using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerSounds : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip pickUpSound;
    public AudioClip takeDamageSound;

    public void itemPickupAudio()
    {
        audioSource.clip = pickUpSound;
        audioSource.Play();
    }

    public void playerTakeDamageAudio()
    {
        audioSource.clip = takeDamageSound;
        audioSource.Play();
    }
}
