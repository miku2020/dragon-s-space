using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public float Health = 100f;
    public float CollisionDamage = 1f;

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") //jos osuu tag.Obstacle tää vähentää elämää -1 pisteellä ja jos 0 niin Game Over on True ja ruutu tulee näkyviin.
        {
            HP_Logic Enemyhealth = other.GetComponent<HP_Logic>();
            if (Enemyhealth != null)
            {
                Enemyhealth.TakeDamage(CollisionDamage);
            }
            TakeDamage(CollisionDamage);
        }
    }
}
//Mikael Huhtakangas 