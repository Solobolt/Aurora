﻿using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

    //Loads a specified level
    //FOR DEMO LOAD LEVEL 1
    public void loadLevel(int level)
    {
        Application.LoadLevel(level);
    }

    //Exits the game (Doesnt work in editor but does work in executable)
    public void quitGame()
    {
        Application.Quit();
    }

}
