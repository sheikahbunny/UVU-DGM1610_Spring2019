using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthDisplay : MonoBehaviour {

    public PlayerMovement UIHealth;
    Text currVal;

    // Use this for initialization
    void Start () {
        UIHealth = GameObject.Find("Player").GetComponent<PlayerMovement>();
        

        currVal = GetComponent<Text>();
    }
	

	// Update is called once per frame
	void Update () {
        currVal.text = " " + UIHealth.userHealth;
	}
}
