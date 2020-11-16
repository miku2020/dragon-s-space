using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameModeSlider : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider slider;
    float volume;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Slider>();
        slider = GetComponent<Slider>();
        audioMixer.GetFloat("volume", out volume);
        slider.value = volume;
    }
 
}
