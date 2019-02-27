using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour
{
    public string stopLight;
    public string mood;
    public string vegetable;
    public bool isUtahn = true;
    public bool isGirl;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (stopLight == "Red")
        {

            if (isUtahn)
            {
                print("Stop! the light is RED!");

            }
            else
            {
                print("Thank you for stopping at the red light!");
            }
        }


        else if (stopLight == "Yellow")
        {
            if (isUtahn)
            {
                print("You've got this bro.");
            }
            else
            {
                print("Thank you for preparing to stop.");
            }

        }
        else if (stopLight == "Green")
        {
            if (isUtahn)
            {
                print("Turn up radio, check phone, sit at the light until almost yellow, then go! ");
            }
            else
            {
                print("Thank you for accelerating forward on a green light!");
            }

        }
        else
        {
            print("Thank you for visiting Utah!");
        }






        //Composition 1 for homework
        if (mood == "happy")
        {
            if (isGirl)
            {
                print("Man, what a good day! I'm going to put some makeup on.");
            }
            else
            {
                print("Wow, today was totally chill, time to play some games!");

            }
            if (mood == "sad")
            {
                if (isGirl)
                {
                    print("What a bummer day, I need some chocolate.");
                }

                else
                {
                    print("ugh, such a bad day. Time to play some games!");
                }

            }
            if (mood == "mad")
            {
                if (isGirl)
                {
                    print("I can't believe the day ended like this!!!! Ugh. I'm going to bed.");
                }
                else
                {
                    print("I could punch today in the face if I wanted too. But I'll hash it out in some videogames instead.");
                }
            }
        }



        //composition 2 homework
        if (vegetable == "bell pepper")
        {
            print("This is very colorful. I enjoy this.");


        }
        else if (vegetable == "broccoli")
        {
            print("This is a very unique texture. I'm not sure I like this.");
        }






        if (vegetable == "cauliflower")
        {

            print("This is not good. I do not enjoy this.");
        }


        else if (vegetable == "carrot")
        {

                print("I enjoy this vegetable. Om nom nom.");
        }

        if (vegetable == "pickle")
        {

                print("I guess this counts as a vegetable.");
        }

        else if (vegetable == "radish")
        {

                print("Oh no no no. This is gross. Throw it away.");
        }

        if (vegetable == "tomato")
        {

            print("This is not a vetegable. You should know this by now.");
        }
        else
        {
            print("This is not a vegetable, try again.");



























        }
    }
}    