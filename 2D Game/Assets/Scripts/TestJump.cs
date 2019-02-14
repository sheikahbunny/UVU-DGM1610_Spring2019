using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJump : MonoBehaviour
{

    public bool onGround;
    private Rigidbody2D rb;
    public float jumpSpeed;
    

    void Start()
    {
        onGround = true;
        rb = gameObject.GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        if (onGround)
        {


            if (Input.GetKey(KeyCode.W))
            {

                rb.velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x,jumpSpeed);
                onGround = true;
            }
        }
    }
}