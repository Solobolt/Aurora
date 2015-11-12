﻿using UnityEngine;
using System.Collections;

public class Enemy3 : Enemy {

    int unitHealth = 50;
    int unitSpeed = 2;
    float fireTime = 10;
    float fireRate = 0.7f;

    public override void SetUnitValues()
    {
        health = unitHealth;
        moveSpeed = unitSpeed;
    }

    //Creates and fires enemy bullets in the direction that the enemy is facing
    public override void FireWeapon()
    {
        if (fireTime >= fireRate)
        {
            fireTime = 0;
            for (int i = 0; i < muzzle.Length; i++)
            {
                Instantiate(enemyLaser, muzzle[i].transform.position, muzzle[i].transform.rotation);
            }
        }
        fireTime += Time.deltaTime;
    }
}
