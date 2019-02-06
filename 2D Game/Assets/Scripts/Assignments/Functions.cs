using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{

    public string emotion;

    void Start()
    {

       mood(emotion);

    }
    void mood(string emotionState)
    {
        if (emotionState == "Happy")
        {
            print("What a good and exciting day today!");
        }
        else if (emotionState == "Sad")
        {
            print("If only things were going right today.");
        }
        else if (emotionState == "Mad")
        {
            print("Why did today have to be the way it is.");

        }
        else if (emotionState == "Scared")
        {
            print("I wish there was someone here with me right now.");

        }
        else
        {
            print("I don't know what you're trying to feel." + emotionState);


        }


    }




}