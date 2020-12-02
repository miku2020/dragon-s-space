using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_logic : MonoBehaviour
{
    public float moveSpeed = 0f;

    public Rigidbody2D rb2d;
    public Transform Firepoint;
    public GameObject Bullet;

    Vector2 movement;

    public Animator animator;
    public AudioSource audioSource;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<AudioSource>().Play();
            Instantiate(Bullet, Firepoint.position, Firepoint.rotation);
            animator.SetTrigger("Shoot");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Seed"))
        {
            SeedCounter.SeedAmount += 1;// Score numero Can Chenge//
            Destroy(other.gameObject);
        }
    }


    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
//Mikael Huhtakangas 
