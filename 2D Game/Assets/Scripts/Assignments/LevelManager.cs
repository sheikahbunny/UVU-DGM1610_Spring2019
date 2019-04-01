using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public GameObject currentCheckPoint;
    private Rigidbody2D pcRigid;

    private GameObject player;


    // Particles
    public GameObject deathParticle;
    public GameObject respawnParticle;


    // Respawn Delay
    public float respawnDelay;


    //Point Penalty on Death
    public int pointPenaltyOnDeath;


    //Store Gravity Value
    private float gravityStore;

     void Start ()
     {
        pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
     }
   
    public void Respawnplayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }
    public IEnumerator RespawnPlayerco()
    {
        //Generate Death Particle
        Instantiate (deathParticle, pcRigid.transform.position, pcRigid.transform.rotation);
        //Hide PC
        player.SetActive(false);
        pcRigid.GetComponent<Renderer>().enabled = false;
        //Gravity Reset
        gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
        pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //Point Penalty
        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        //Debug Message
        Debug.Log("PC Respawn");
        //Respawn Delay
        yield return new WaitForSeconds(respawnDelay);
        //Gravity Restore
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        //Match PCs transform position
        pcRigid.transform.position = currentCheckPoint.transform.position;
        //Show PC
        player.SetActive(true);
        pcRigid.GetComponent<Renderer>().enabled = true;
        //spawn PC
        Instantiate (respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);


    }

}
