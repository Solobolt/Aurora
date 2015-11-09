using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    //Holds a list of the controllers registered to the pc
    private string[] controllers;

    //Values depening on the player
    public int[] score;

    //Hold the number of players from the number of controllers
    private int numPlayers = 0;

    //Player Prefab
    public GameObject player;
    public List<PlayerMovement> PlayerList = new List<PlayerMovement>();
    private bool isNumbSet = false;

    // Use this for initialization
    void Start () {
        CheckControllers();
    }
	
	// Update is called once per frame
	void Update () {
        setPlayerNumb();
    }

    //sets the player numbers correctly
    private void setPlayerNumb()
    {
        //Having the bool check will prevent the game from rewriting strings every frame
        if (isNumbSet == false)
        {
            PlayerList[1].playerNumb = 2;
            PlayerList[1].SetStrings();
            isNumbSet = true;
        }
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

                    //Create a player
                    Instantiate(player,new Vector3(0,0,0),new Quaternion(0,0,0,0));

                    //Adds to the number of players
                    numPlayers++;
                }
            }
        }
    }

    //Adds a player to the list
    public void addPlayer(PlayerMovement playerMoveScript)
    {
        PlayerList.Add(playerMoveScript);
    }
}
