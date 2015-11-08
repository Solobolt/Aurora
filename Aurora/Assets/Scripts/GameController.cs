using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    //Holds a list of the controllers registered to the pc
    private string[] controllers;

    //Values depening on the player
    public int[] score;
    private bool[] isAlive;

    //Hold the number of players from the number of controllers
    private int numPlayers = 0;
    
	// Use this for initialization
	void Start () {
        CheckControllers();
    }
	
	// Update is called once per frame
	void Update () {

    }

    // Collects an array of controller inputs
    void CheckControllers()
    {
        controllers = Input.GetJoystickNames();
        for (int i = 0; i < Input.GetJoystickNames().Length; i++)
        {
            if (controllers[i] != null)
            {
                if (controllers[i] != "")
                {
                    //Spawns the player
                    print("Player " + i + " Spawn");

                    //Adds to the number of players
                    numPlayers++;

                    //confirms that the player is alive
                    isAlive[i] = true;
                }
            }
        }
    }
}
