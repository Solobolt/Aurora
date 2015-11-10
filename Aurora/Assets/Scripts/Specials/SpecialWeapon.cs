using UnityEngine;
using System.Collections;

public class SpecialWeapon : MonoBehaviour {

	private Transform myTransform;

	private string fire2;

	private int playerNumb;

	// Use this for initialization
	void Start () {
		playerNumb = GetComponentInParent<PlayerAiming>().playerNumb;
		myTransform = this.transform;
		fire2 = "P" + playerNumb + "_Fire2";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Check for inputs
	private void CheckInputs()
	{
		
	}
}
