using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float gameSpeed;
    public PlayerMovement player;
    [Range(0, 5)]
    public float gameSpeedRegulator;
    public float speedRate = 0.5f;
    public float gameSpeedMax = 5;

    void Update()
    {
        if (player.points % 5 == 0)
        {
            if (gameSpeedRegulator <= gameSpeedMax)
            {
                gameSpeedRegulator += speedRate * Time.deltaTime;
            }
        }
        
        gameSpeed = gameSpeedRegulator;
    }
}
