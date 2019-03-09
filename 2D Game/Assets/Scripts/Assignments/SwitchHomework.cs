using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchHomework : MonoBehaviour {

    public string suspect;
    public string weapon;
    public string room;
    public string weather;
	
	void Start () {
        MurderMystery(suspect);
        Weather(weather);
	}
	
	void Update () {
		
	}
    void MurderMystery(string person)
    {
        switch (person)
        {
            case "Mr. Ketchup":
            case "Mr. Mustard":
                print("I was in the billiard room smoking a cigar and playing... cut throat...");
                break;
            case "Ms. Frysauce":
                print("I was in the kitchen cleaning up the dishes with the scrubber");
                break;
            default:
                print("I am not familiar with " + person + "!");
                break;

        }
    }
    void Weather(string state)
    {
        switch (state)
        {
            case "snow":
            case "blizzard":
                print("It's so cold! I need to grab my coat and scarf!");
                break;
            case "sunny":
                print("Ugh, another hot day. Who wants icecream?");
                break;
            case "rain":
                print("It's my favorite kind of weather! Time to grab my rain boots and umbrella!");
                break;
            case "windy":
                print("I think I have a kite laying around here somewhere?");
                break;
            case "foggy":
                print("I hope slender man isn't lurking around here somewhere...");
                break;
            default:
                print("I am not familiar with" + state + ".");
                break;
        }
    }
        
     
}
