using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{

    public string weather;

    void Start()
    {

        Weather(weather);

    }
    void Weather(string weatherState)
    {
        if (weatherState == "Sunny")
        {
            print("Eew, the suns gross!");
        }
        else if (weatherState == "Raining")
        {
            print("YES, its FINALLY raining! Where's my umbrella");
        }
        else if (weatherState == "Windy")
        {
            print("gotta grab my jacket, it's cold.");

        }
        else if (weatherState == "Snowing")
        {
            print("brrr... it's time to grab my snowboard!");

        }
        else
        {
            print("Looks like theres nothing here " + weatherState);


        }


    }




}