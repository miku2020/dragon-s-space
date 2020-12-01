using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Logic : MonoBehaviour
{
    
    private bool flickerbool;
    private int i = 0;
    [Header("vedä tähän Pelaajan Child Objekti jossa on grafiikka")]
    public GameObject Lohari;
    [Header("kuinka kauan flikkeröi")]
    public float flickerT;
    [Header("kuinka nopeasti flikkeröi")]
    public float flickerR;

    [Header("Elämän määrä")]
    public float Health = 100;
    [Header("Laita Game_Over objekti hiearchiasta tähän (Render kuvalle off)")]
    public GAME_OVER GameOverScript;
    [Header("Score. jätä tyhjäksi")]
    public int Score;

    // for blinking and not taking damage
    public Animator animator;
    float timer = 0;



    private void Awake()
    {
        
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            flickerbool = false;
        }
        else
        {
            flickerbool = true;
        }
    }


    public void TakeDamage(float damage)
    {
        if (flickerbool == false)
        {
            Health -= damage;
            StartCoroutine("Damageless");
            timer = flickerT;
        }
            
        //StartCoroutine(Flicker());
        if (Health <= 0)
        {            
            GameOverScript.GameOver = true;
            Debug.Log("final Score: " + Score);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Health_pickup") //kun osuu tag.Health_pickup niin lisää 1 elämään.
        {
            Health += 1;
            Debug.Log("Hit___Remaining_Health:_" + Health);            
        }
        if (other.tag == "Score_pickup")
        {
            Score++;
            Debug.Log("Score: " + Score);
        }
    }

    IEnumerator Flicker()
    {
        var fmaterial = Lohari.GetComponent<SpriteRenderer>();
        var collider = GetComponent<Collider2D>();
        GetComponent<Collider2D>().enabled = false;

        for (i = 0; i < flickerT; i++)
        {
           
            fmaterial.color = new Color(1.0f, 1.0f, 1.0f, 0f);
            yield return new WaitForSeconds(flickerR);
            fmaterial.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            yield return new WaitForSeconds(flickerR);                    
                        
        }       
        
        flickerbool = false;
        GetComponent<Collider2D>().enabled = true;
    }

    IEnumerator Damageless()
    {
        animator.SetBool("isBlinking", true);
        yield return new WaitForSecondsRealtime(flickerT);
        animator.SetBool("isBlinking", false);
    }


}
//Mikael Huhtakangas 
