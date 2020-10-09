using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_logIIc : MonoBehaviour
{

    /// <summary>
    /// 
    /// </summary>

   private Transform target;

    //public float offset;
    private bool Safety;

    [Header("lisää ampumis piste tähän")]
    public Transform Firepoint;
    [Header("siirä ammus Prefab tähän")]
    public GameObject Bullet;
    [Header("säätää tulinopeutta")]
    public int RoF;
    public void Start()
    {

        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Safety = false;



    }

    public void shoot() //luo ammuksen
    {
        Instantiate(Bullet, Firepoint.position, Firepoint.rotation);
    }

    IEnumerator ShootTimer() //käynistää laukaus kieroksen
    {
        // Debug.Log("Wait!");



        if (Safety == true)
        {
            yield return new WaitForSeconds(RoF);
            //Debug.Log("Shoot!" + Safety);
            shoot();
            StartCoroutine(ShootTimer());
        }

    }
    private void OnTriggerEnter2D(Collider2D other) // käskee aloittaa laukaus kieroksen 
    {
        if (other.tag == "Player") { 
            //Debug.Log("Enter!");
            Safety = true;
        StartCoroutine(ShootTimer());
    }
    }
    void OnTriggerExit2D(Collider2D other) // lopettaa Laukaus kieroksen
    {
        if (other.tag == "Player")
        {
            //Debug.Log("Exit!");
            Safety = false;
        }
    }

}
//Mikael Huhtakangas 