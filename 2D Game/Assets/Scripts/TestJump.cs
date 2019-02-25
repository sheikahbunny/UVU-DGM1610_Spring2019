using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJump : MonoBehaviour
{
    //Player movement variables
    public bool onGround;
    private Rigidbody2D rb;
    public float jumpSpeed;
    //Player grounded variables
    private bool grounded = true;

    void Start()
    {
        grounded = true;
        rb = gameObject.GetComponent<Rigidbody2D>();

    }


    void Update()
    //Make player jump
    {
        
        {


            if (Input.GetKeyDown(KeyCode.W) && grounded)
            {

                rb.velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x,jumpSpeed);
                grounded = true;
            }
        }
    }
}