using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public Sprite[] HeartSprites;

    public Image HeartUI;

    private PlayerMovement player;
    public PlayerMovement currHealth;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        currHealth = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }
     void Update()
    {
        HeartUI.sprite = HeartSprites[currHealth.userHealth];
    }
}
