using UnityEngine;
using System.Collections;
using System;

public class SingleFireLaser : Weapon {

    private float fireRate = 0.1f;
    private float fireTime = 1.0f;

    public GameObject projectile;

    //Handles the weapon effects
    public override void fireWeapon()
    {
        fireTime += Time.deltaTime;

        if(fireTime >= fireRate)
        {
            Instantiate(projectile,myTransform.position,myTransform.rotation);
            fireTime = 0;
        }
    }
}
