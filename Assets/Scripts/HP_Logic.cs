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



    private void Awake()
    {
        
    }


    public void TakeDamage(float damage)
    {
        Health -= damage;
        flickerbool = true;
        StartCoroutine(Flicker());
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
            fmaterial.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
            yield return new WaitForSeconds(flickerR);
            fmaterial.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            yield return new WaitForSeconds(flickerR);
        }

        flickerbool = false;
        GetComponent<Collider2D>().enabled = true;
    }

}
//Mikael Huhtakangas 
