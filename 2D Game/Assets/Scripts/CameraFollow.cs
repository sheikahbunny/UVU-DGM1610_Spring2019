using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public PlayerMovement player;

    public bool isFollowing;

    


    //camera position offset


    public float xOffset;
    public float yOffset;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerMovement>();

        isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (isFollowing)
        {
            transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, player.transform.position.z);
        }
	}
}
