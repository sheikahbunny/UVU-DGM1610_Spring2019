using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hitWall;

    public float lockPos = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        hitWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);


        if (hitWall)
        {
            moveRight = !moveRight;
        }


        if (moveRight)
        {
            transform.localScale = new Vector3(-1.439481f, 1.580479f, 2.8909f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(1.439481f, 1.580479f, 2.8909f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);


        }
    }
}
