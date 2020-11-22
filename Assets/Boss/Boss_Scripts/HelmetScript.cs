using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class HelmetScript : MonoBehaviour
{
    public Sprite[] helmetPhace;    
    private SpriteRenderer spriteRenderer;    
    public int currentSprite;
    public AudioSource crackSound;



    // Start is called before the first frame update
    void Start()
    {
       spriteRenderer = GetComponent<SpriteRenderer>();       
       spriteRenderer.sprite = helmetPhace[currentSprite];  
       
    }   

    public void ChangeHelmetSprite()
    {
        currentSprite++;
        spriteRenderer.sprite = helmetPhace[currentSprite];        
        crackSound.Play();
    }
}
