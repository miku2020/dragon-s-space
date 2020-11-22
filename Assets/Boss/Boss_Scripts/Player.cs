using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;

    


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);

        //rb.velocity = movement * speed;
        //transform.Translate(speed * Input.GetAxis("Horizontal"), speed * Input.GetAxis("Vertical"), 0f);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
           
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        

    }

    private void OnParticleCollision(GameObject other)
    {
      
        Debug.Log("AAAAAAAAA");
        GameObject.Find("CameraObject").SendMessage("DoShake");




    }
}
