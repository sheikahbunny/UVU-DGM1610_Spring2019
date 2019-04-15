using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;


    private bool grounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;




    private float moveVelocity;

    public Animator animator;

	void Start () {
        animator.SetBool("isWalking", false);
        animator.SetBool("isJumping", false);
	}
    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
    // Update is called once per frame
    void Update() {


        if (Input.GetKey(KeyCode.D)) {
            
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            animator.SetBool("isWalking", true);
        }
        else if(Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("isWalking", false);
        }
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            
            animator.SetBool("isWalking", false);
        }
         
        
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
        }
        if (grounded)
        {
            animator.SetBool("isJumping", false);
        }
        //Player Flip
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(26.5877f, 24.5118f, 1f);
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(-26.5877f, 24.5118f, 1f);

        

         
        
	}
    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        animator.SetBool("isJumping", true);
    }
}
