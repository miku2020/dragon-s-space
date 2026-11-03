using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    /// <summary>
    /// Ammuksen koodi
    /// </summary>


    [Header("Ammuksen nopeus")]
    public float speed = 10f;
    [Header("Vedä oma Riggidbody2D tähän")]
    public Rigidbody2D rb;
    [Header("Ammuksen etäisyys")]
    public float range = 0f;
    [Header("Ammuksen Vahingon määrä")]
    public float damage = 0f;

  
    void Start()
    {
       // Debug.Log("bullet is flying");
        rb.linearVelocity = transform.right * speed; //siirtää ammusta
        DestroyObjectDelayed(); //tuhoaa ammuksen tietyn matkan jälkee
    }

    void DestroyObjectDelayed()
    {
        Destroy(gameObject, range);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        if (hitInfo.tag == "Enemy")
        {
            EnemyHP Enemyhealth = hitInfo.GetComponent<EnemyHP>();
            if (Enemyhealth != null)
            {
                Enemyhealth.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
        else if (hitInfo.tag == "Player")
        {
            HP_Logic Enemyhealth = hitInfo.GetComponent<HP_Logic>();
            if (Enemyhealth != null)
            {
                Enemyhealth.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
//Mikael Huhtakangas 