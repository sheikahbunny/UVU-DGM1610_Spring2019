using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

    public LevelManager levelManager;
    public bool deathBox;

    void Start ()
    {
        levelManager = FindObjectOfType <LevelManager>();
    }





	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement HP = other.GetComponent<PlayerMovement>();
            if (deathBox)
            {
                levelManager.Respawnplayer();
            }
            if (HP.userHealth == 1)
            {
                levelManager.Respawnplayer();
                HP.userHealth += 2;
            }
            else if (HP.userHealth > 1) 
            {
                HP.userHealth -= 1;
                other.GetComponent<Rigidbody2D>().velocity *= -2;
            }

            
            if(HP.userHealth > 3)
            {
                HP.userHealth = 3;
            }
        }
            
    }
}
