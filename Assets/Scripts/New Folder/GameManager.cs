using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerController playerController;
    private PlayerModel playerModel;
    private PlayerView playerView;

    void Start()
    {
        playerView = FindObjectOfType<PlayerView>();
        playerModel = new PlayerModel(playerView.moveSpeed,playerView.bulletForce);
        playerController = new PlayerController(playerModel, playerView);
    }

    void Update()
    {
        playerController.Update();
    }
}
