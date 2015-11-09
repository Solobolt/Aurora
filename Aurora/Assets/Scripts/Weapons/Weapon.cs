using UnityEngine;
using System.Collections;

public abstract class Weapon : MonoBehaviour {

    private string fire1;

    private int playerNumb;
    private bool numbChecked = false;
    
    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        SetStrings();
        CheckInputs();
    }
    
    //Handles Inputs
    void CheckInputs()
    {
        if (Input.GetAxis(fire1) != 0 || Input.GetKey("w"))
        {
            fireWeapon();
        }
    }

    //Sets the controller strings
    void SetStrings()
    {
        if (numbChecked == false)
        {
            playerNumb = gameObject.GetComponentInParent<PlayerAiming>().playerNumb;
            fire1 = "P" + playerNumb + "_Fire1";
        }
    }

    //Handles what happens when the player hits the fire button
    public abstract void fireWeapon();

}
