using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerModel 
{
    public float moveSpeed;
    public float bulletForce;


    public PlayerModel(float moveSpeed, float bulletForce) 
    {
        this.moveSpeed = moveSpeed;
        this.bulletForce = bulletForce;
    }
}
