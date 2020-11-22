using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootScript : MonoBehaviour
{
    //public ParticleSystem playerParticalSystem;
    public Boss boss;

    private void Start()
    {
        boss = GetComponentInParent<Boss>();
    }
    private void OnParticleCollision(GameObject other)
    {              
        Debug.Log("We hit the boss!");
        boss.bossHealth -= 1;
        boss.counter++;
        boss.animator.SetTrigger("hit");   
               
    }
}
