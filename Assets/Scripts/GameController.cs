using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public static float gameSpeed;
    public PlayerMovement player;
    [Range(0, 5)]
    public float gameSpeedRegulator;
    public float speedRate = 0.5f;
    public float gameSpeedMax = 5;
    int _scenenum;

    public bool _levelcomplete = false;
    private void Start()
    {
        _scenenum = SceneManager.GetActiveScene().buildIndex;
    }

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

        if(((player.points * _scenenum) % 25 == 0) & (player.points != 0))
        {
            print("lvl complete");
            _levelcomplete = true;
        }
    }
}
