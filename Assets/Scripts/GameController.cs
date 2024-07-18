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
    [SerializeField] WinPlayerBehavior winPlayerBehavior;
    public bool _levelcomplete = false;
    
    private void Start()
    {
        _scenenum = SceneManager.GetActiveScene().buildIndex;
        winPlayerBehavior.enabled = false;
    }
    

    void Update()
    {
        if (FindObjectOfType<ItemManager>().numberOfItems % 5 == 0)
        {
            if (gameSpeedRegulator <= gameSpeedMax)
            {
                gameSpeedRegulator += speedRate * Time.deltaTime;
            }
        }
        
        gameSpeed = gameSpeedRegulator;

        if((FindObjectOfType<ItemManager>().numberOfItems % (12*_scenenum) == 0) & (FindObjectOfType<ItemManager>().numberOfItems != 0))
        {
            _levelcomplete = true;
            player.GetComponent<CircleCollider2D>().enabled = false;
            player.enabled = false;
            winPlayerBehavior.enabled = true;
        }
    }
}
