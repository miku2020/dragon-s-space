using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageForBoss : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Boss")
        {

            if (hitInfo.GetComponentInParent<Boss>().bossHealth > 0)
            {
                Debug.Log("We hit the boss!");
                hitInfo.GetComponentInParent<Boss>().bossHealth -= 1;
                hitInfo.GetComponentInParent<Boss>().counter++;
                hitInfo.GetComponentInParent<Animator>().SetTrigger("hit");
                Destroy(gameObject);
            }

        }

    }
}
