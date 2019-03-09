using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysListsDicts : MonoBehaviour {

    public string client1 = "Greg";

    public string client2 = "Kate";

    public string client3 = "Adam";

    public string client4 = "Mia";

    public string client5 = "Fred";

    //Array Example
    public string[] clientList = new string[] { "Greg", "Kate", "Adam", "Mia", "Fred" };
    //List Example
    public List<string> santasList = new List<string>();

    public ArrayList inventory = new ArrayList();
    // Use this for initialization
    void Start () {
        santasList.Add("Jimmy");
        santasList.Add("Jenny");
        santasList.Add("Sam");
        santasList.Add("Ty");
        santasList.Add("Susan");
        santasList.Remove("Jimmy");

        print(clientList[2]);
        print(santasList[3]);

        inventory.Add(10);
        inventory.Add("Bob");
        inventory.Add(true);
        inventory.Add(5.2341);

        print(inventory[2]);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
