using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{

    private PlayerModel model;
    private PlayerView view;

    public PlayerController(PlayerModel model, PlayerView view)
    {
        this.model = model;
        this.view = view;
    }

    public void Update()
    {
        HandleInput();
        HandleFire();
     
    }

    private void HandleInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector3 input = new Vector3(moveX, 0, moveY);

        if(input!= Vector3.zero) 
        {
            Quaternion rotation = Quaternion.LookRotation(input);
            view.gameObject.transform.rotation = rotation;
        }

        input.Normalize();
        view.MovePosition(input * model.moveSpeed);
    }

    private void HandleFire()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            view.Fire(view.transform.forward * model.bulletForce);
        }
    }

}
