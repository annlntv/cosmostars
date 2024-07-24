using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.SocialPlatforms.Impl;

public class UI : MonoBehaviour
{
    public PlayerMovement player;
    public TextMeshProUGUI pointsText;
    public GameObject defeatUI;
    public TMP_Text score;
    public TMP_Text winScore;
    public GameController gameController;

    public GameObject winUI;
    public GameObject HUD;

    SceneTransition transition;

    private void Start()
    {
        transition = FindObjectOfType<SceneTransition>();
    }
    void Update()
    {
        pointsText.text = player.points.ToString();

        if (player == null)
        {
            defeatUI.SetActive(true);
            score.text = "Best Score: " + PlayerPrefs.GetInt("score").ToString();
        }

        if(gameController._levelcomplete)
        {
            winUI.SetActive(true);
            HUD.SetActive(false);
            winScore.text = "Score: " + player.points.ToString();
        }
    }

    public void OnClickRestart()
    {

        int index = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadScene(index);
        transition.SceneLoader(index);
    }

    public void OnClickToMenu()
    {
        //SceneManager.LoadScene(0);
        transition.SceneLoader(1);
    }

    public void OnClickNextLevel()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        transition.SceneLoader(index+1);
        //SceneManager.LoadScene(index + 1);
    }
}
