using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BossSounds : MonoBehaviour
{
    public AudioSource shoot_tentacle_Sound;
    public AudioSource shoot_eye_Sound;
    public AudioSource shoot_portals_Sound;
    public AudioSource shoot_headAttack_Sound;
    public AudioSource handRotating_Sound;
    public AudioSource hitReaction_Sound;

    public void ShootTentacleAudio()
    {
        shoot_tentacle_Sound.Play();
    }

    public void ShootEyeAudio()
    {
        shoot_eye_Sound.Play();
    }

    public void ShootPortalsAudio()
    {
        shoot_portals_Sound.Play();
    }

    public void ShootHeadAttackAudio()
    {
        shoot_headAttack_Sound.Play();
    }

    public void HandRotatingAudio()
    {
        handRotating_Sound.Play();
    }

    public void HitReactionAudio()
    {
        hitReaction_Sound.Play();
    }


}
