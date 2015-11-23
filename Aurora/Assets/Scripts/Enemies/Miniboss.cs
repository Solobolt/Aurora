using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Miniboss : MonoBehaviour {

    //sets the miniboss's health
    private int health = 1000;
    private int TotalHealth = 1000;
    private int damage = 10;
    public Slider healthBarSlider;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Removes health if the player is hit by a laser
    void OnTriggerEnter(Collider otherObject)
    {
        if(otherObject.gameObject.tag == "Laser")
        {
            RemoveHealth();
        }
    }

    //Removes health
    void RemoveHealth()
    {
        health -= damage;
        healthBarSlider.value = healthBarSlider.value - 0.01f;

        if (health <= 0)
        {
            healthBarSlider.value = 0f;
            Destroy(this.gameObject);
        }
    }
}
