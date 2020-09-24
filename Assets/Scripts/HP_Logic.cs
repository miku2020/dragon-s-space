using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Logic : MonoBehaviour
{
    [Header("Elämän määrä")]
    public float Health = 100;
    [Header("Laita Game_Over objekti hiearchiasta tähän (Render kuvalle off)")]
    public GAME_OVER GameOverScript;
    [Header("Score. jätä tyhjäksi")]
    public int Score;
    public void TakeDamage(float damage)
    {
        Health -= damage;
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

}
//Mikael Huhtakangas 
