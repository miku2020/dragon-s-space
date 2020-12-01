using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageFromBossBullets : MonoBehaviour
{    

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("BossBullets");
        GetComponentInParent<HP_Logic>().TakeDamage(1);            
    }
}
