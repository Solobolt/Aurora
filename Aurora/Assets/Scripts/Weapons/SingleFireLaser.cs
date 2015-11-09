using UnityEngine;
using System.Collections;
using System;

public class SingleFireLaser : Weapon {

    public float fireRate = 0.5f;
    private float fireTime = 0.0f;

    //Handles the weapon effects
    public override void fireWeapon()
    {
        fireTime += Time.deltaTime;

        if(fireTime >= fireRate)
        {
            print("Firing Weapon");
            fireTime = 0;
        }
    }
}
