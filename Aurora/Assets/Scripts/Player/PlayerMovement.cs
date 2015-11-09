using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public int playerNumb = 1;

    private GameController gameController;

    //Holds movement values
    private Transform myTransform;
    private int moveSpeed = 20;

    //Hold strings for the controller
    private string horizontal;
    private string vertical;    

	// Use this for initialization
	void Start () {
        myTransform = this.transform;
        SetStrings();
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        gameController.addPlayer(this);
    }
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    //Sets strings depeing on the player numb
    public void SetStrings()
    {
        //Base string { = "P" + playerNumb + "_"}
        horizontal = "P" + playerNumb + "_Horizontal";
        vertical = "P" + playerNumb + "_Vertical";
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
            currentPos.z += moveSpeed * Time.deltaTime * Input.GetAxis(vertical);
        }

        //sets the new postion
        myTransform.position = currentPos;
    }
}
