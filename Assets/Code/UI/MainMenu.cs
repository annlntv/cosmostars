using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_Text score;
    [SerializeField] int sceneName;

    SceneTransition transition;
    public void Start()
    {
        score.text = "Best Score: " + PlayerPrefs.GetInt("score").ToString();
        transition = FindObjectOfType<SceneTransition>();
    }
    public void OnClickStart()
    {
        //SceneManager.LoadScene(sceneName);
        transition.SceneLoader(sceneName);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
