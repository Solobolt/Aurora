using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public int playerNumb = 1;

    //Holds movement values
    private Transform myTransform;
    private int moveSpeed = 10;

    //Hold strings for the controller
    private string horizontal;
    private string vertical;
    //private string fire1;
    //private string fire2;
    

	// Use this for initialization
	void Start () {
        myTransform = this.transform;
        SetStrings();
    }
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    //Sets strings depeing on the player numb
    private void SetStrings()
    {
        //Base string { = "P" + playerNumb + "_"}
        horizontal = "P" + playerNumb + "_Horizontal";
        vertical = "P" + playerNumb + "_Vertical";
       // fire1 = "P" + playerNumb + "_Fire1";
       // fire2 = "P" + playerNumb + "_Fire2";
    }

    //Handles movement
    private void Movement()
    {
        //Place holder for postion edits
        Vector3 currentPos = myTransform.position;

        //Moves the player alongg the X Axis
        if (Input.GetAxis(horizontal) != 0)
        {
            currentPos.x += moveSpeed * Time.deltaTime * Input.GetAxis(horizontal);
        }

        //moves the player along the Y axis
        if (Input.GetAxis(vertical) != 0)
        {
            currentPos.y += moveSpeed * Time.deltaTime * Input.GetAxis(vertical);
        }

        //sets the new postion
        myTransform.position = currentPos;
    }
}
