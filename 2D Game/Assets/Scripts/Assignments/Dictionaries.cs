using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour {

    public Hashtable personalDetails = new Hashtable();
    public Hashtable fruitDetails = new Hashtable();
    public Hashtable farmAnimals = new Hashtable();
	void Start () {
        personalDetails.Add("firstName", "Greg");
        personalDetails.Add("lastName", "Lukosek");
        personalDetails.Add("gender", "male");
        personalDetails.Add("isMarried", true);
        personalDetails.Add("age", 29);


        fruitDetails.Add("fruitName", "Apple");
        fruitDetails.Add("color", "Red");
        fruitDetails.Add("treeFruit", true);
        fruitDetails.Add("seeds", true);
        fruitDetails.Add("crunchy", true);


        fruitDetails.Add("fruitName", "Banana");
        fruitDetails.Add("color", "Yellow");
        fruitDetails.Add("treeFruit", true);
        fruitDetails.Add("seeds", true);
        fruitDetails.Add("crunchy", false);


        fruitDetails.Add("fruitName", "Grape");
        fruitDetails.Add("color", "Purple");
        fruitDetails.Add("treeFruit", false);
        fruitDetails.Add("seeds", true);
        fruitDetails.Add("crunchy", true);


        farmAnimals.Add("animalName", "Cow");
        farmAnimals.Add("produceMilk", true);
        farmAnimals.Add("age", 7);
        farmAnimals.Add("gender", "female");


        farmAnimals.Add("animalName", "Chicken");
        farmAnimals.Add("produceMilk", false);
        farmAnimals.Add("age", 3);
        farmAnimals.Add("gender", "male");


        farmAnimals.Add("animalName", "Pig");
        farmAnimals.Add("produceMilk", true);
        farmAnimals.Add("age", 10);
        farmAnimals.Add("gender", "female");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
