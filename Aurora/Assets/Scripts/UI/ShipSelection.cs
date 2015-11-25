using UnityEngine;
using System.Collections;

public class ShipSelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Sets the player 1st players ship type
    public void P1SetShipType(int ship)
    {
            PlayerPrefs.SetInt("P1_SHIPTYPE", ship);
        print("Setting player pref 1");
    }

    //Sets the player 1st players ship type
    public void P2SetShipType(int ship)
    {
        PlayerPrefs.SetInt("P2_SHIPTYPE", ship);
        print("Setting player pref 2");
    }
}
