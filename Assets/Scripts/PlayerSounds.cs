using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerSounds : MonoBehaviour
{    
    public AudioSource shoot;  

    public void ShootAudio()
    {
        shoot.Play();
    }
}
