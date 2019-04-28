using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {
    public float multiplier = 1.7f;
    public float duration;
    public GameObject pickupEffect;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        PlayerMovement speedup = player.GetComponent<PlayerMovement>();
        speedup.moveSpeed *= multiplier;

        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;

        yield return new WaitForSeconds(duration);

        speedup.moveSpeed /= multiplier;


        Destroy(gameObject);
    }
}
