using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.SocialPlatforms.Impl;

public class ZenUI : MonoBehaviour
{
    public PlayerMovement player;
    public TextMeshProUGUI pointsText;
    public GameObject defeatUI;
    public TMP_Text score;
    public ZenController gameController;
    SceneTransition transition;
    void Update()
    {
        pointsText.text = player.points.ToString();

        if (player == null)
        {
            defeatUI.SetActive(true);
            score.text = "Score: " + PlayerPrefs.GetInt("score").ToString();
        }

    }

    public void OnClickRestart()
    {

        int index = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadScene(index);
        transition = FindObjectOfType<SceneTransition>();
        if (transition != null)
        {
            transition.SceneLoader(index);
        }
    }

    public void OnClickToMenu()
    {
        transition = FindObjectOfType<SceneTransition>();
        if (transition != null)
        {
            transition.SceneLoader(1);
        }
    }

    public void OnClickNextLevel()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index + 1);
    }
}
