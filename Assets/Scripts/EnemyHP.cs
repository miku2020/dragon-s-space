using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{

    private bool flickerbool;
    private int i = 0;
    [Header("kuinka kauan flikkeröi")]
    public float flickerT;
    [Header("kuinka nopeasti flikkeröi")]
    public float flickerR;

    public float Health = 100f;
    public float CollisionDamage = 1f;

    public void TakeDamage(float damage)
    {
        Health -= damage;
        flickerbool = true;
        StartCoroutine(Flicker());
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

    IEnumerator Flicker()
    {
        var fmaterial = GetComponent<SpriteRenderer>();
        var collider = GetComponent<Collider2D>();
        GetComponent<Collider2D>().enabled = false;

        for (i = 0; i < flickerT; i++)
        {
            fmaterial.color = new Color32(255, 100, 100 , 255);          
            yield return new WaitForSeconds(flickerR);
            fmaterial.color = new Color32(255, 255, 255, 255);
            yield return new WaitForSeconds(flickerR);
        }

        flickerbool = false;
        GetComponent<Collider2D>().enabled = true;
    }

}
//Mikael Huhtakangas 