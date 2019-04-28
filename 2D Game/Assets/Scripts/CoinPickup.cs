using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

    public int coinValue;
    public bool isHealth;
    public int healUp;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            PlayerMovement healthVal = other.GetComponent<PlayerMovement>();
            print("You've Collected the coin!");
            if (isHealth)
            {
                if (healthVal.userHealth < 3)
                {
                    healthVal.userHealth += 1;
                }
                else if(healthVal.userHealth>= 3)
                {
                    healthVal.userHealth = 3;
                }
            }

          
            ScoreManager.AddPoints(coinValue);

            Destroy(gameObject);
            // add digitized coin for script
        }
        
    }
}