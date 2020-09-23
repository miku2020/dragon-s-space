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

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, Firepoint.position, Firepoint.rotation);
        }
    }


    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
