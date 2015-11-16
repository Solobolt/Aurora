using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour 
{
	public Material[] materials;
	public float delay;
	private int index;
	public Renderer renderer;
	
	// Use this for initialization
	void Start () 
	{
		index = 0;
		renderer = GetComponent<Renderer> ();
		//renderer.enabled=true;

	}
	
	// Update is called once per frame
	void Update () 
	{
//		if (Input.GetKeyUp (KeyCode.M)) 
//		{
//			this.renderer.material= materials [index];
//			index = (index + 1) % materials.Length;
//		}
		StartCoroutine (ChangingMaterials ());
	}

	IEnumerator ChangingMaterials()
	{
		if (index == 0) 
		{
			yield return new WaitForSeconds (delay);
			this.renderer.material = materials [index];
			index = 1;
			yield return new WaitForSeconds (delay);
			this.renderer.material = materials [index];
			index = 2;
			yield return new WaitForSeconds (delay);
			index=0;
		}

		//index = (index + 1) % materials.Length;

	}

}
