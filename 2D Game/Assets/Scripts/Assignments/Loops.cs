using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
    public int bottles = 0;
    int count = 0;

    void Start() {
        //for Loops
        for (int i = 100; i > bottles; --i)
        {
            print(i + "bottles of beer on the wall");
        }

        //Do While Loops
        bool shouldContinue = false;

        do
        {
            print("Hello World");
        } while (shouldContinue == true);

        //For Each Loop
        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach(string item in strings)
        {
            print (item);
        }


    }
    
}

 
