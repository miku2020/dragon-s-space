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
    public float range = 0;
    [Header("Ammuksen Vahingon määrä (ei ole käytös)")]
    public float damage = 0;

  
    void Start()
    {
       // Debug.Log("bullet is flying");
        rb.velocity = transform.right * speed; //siirtää ammusta
        DestroyObjectDelayed(); //tuhoaa ammuksen tietyn matkan jälkee
    }

    void DestroyObjectDelayed()
    {
        Destroy(gameObject, range);
    }

    /*private void OnTriggerEnter(Collider hitInfo) 
    {
        EnemyHp Enemyhealth = hitInfo.GetComponent<EnemyHp>();
        if (Enemyhealth != null)
        {
            Enemyhealth.TakeDamage(damage);
        }
        Destroy(gameObject);
    }*/
}
//Mikael Huhtakangas 