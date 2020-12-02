using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerSounds : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip playerShootSound;
    public AudioClip pickUpSound;
    public AudioClip takeDamageSound;

    [Range(0f, 1f)]
    public float playerShootSoundVolume;

    [Range(0f, 1f)]
    public float itemPickupVolume;

    [Range(0f, 1f)]
    public float takeDamageSoundVolume;

    //private AudioSource pickUpSource;

    public void ItemPickupAudio()
    {
        audioSource.PlayOneShot(pickUpSound, itemPickupVolume);
    }

    public void PlayerTakeDamageAudio()
    {
        audioSource.PlayOneShot(takeDamageSound, takeDamageSoundVolume);
    }

    public void PlayerShootAudio()
    {
        audioSource.PlayOneShot(playerShootSound, playerShootSoundVolume);
    }
}
