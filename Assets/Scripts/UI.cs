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
    void Update()
    {
        pointsText.text = player.points.ToString();

        if (player == null)
        {
            defeatUI.SetActive(true);
            score.text = "Best Score: " + PlayerPrefs.GetInt("score").ToString();
        }
    }

    public void OnClickRestart()
    {

        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }

    public void OnClickToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
