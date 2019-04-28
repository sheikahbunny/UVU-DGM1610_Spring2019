using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    public Transform firePoint;
    public GameObject projectile;


	// Use this for initialization
	void Start () {
        //projectile needs to be added to prefabs
        projectile = Resources.Load("Prefabs/Ammo") as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
            Instantiate(projectile, firePoint.position, firePoint.rotation);


	}
}
