using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    //Indexed Level to load
    public int levelToLoad;
    //This function loads the level stored in the levelToLoad variable
    public void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }
    //This function allows you to exit the level/game
    public void LevelExit()
    {
        Application.Quit();
    }
    
	
	
}
