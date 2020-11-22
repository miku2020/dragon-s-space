using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawScript : MonoBehaviour
{

    public float damageFromClaws = 0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            HP_Logic playerHealth = collision.GetComponent<HP_Logic>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageFromClaws);
                Debug.Log("CLAW!");
            }
        }
    }
}
