using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_Text score;
    [SerializeField] string sceneName;
    public void Start()
    {
        score.text = "Best Score: " + PlayerPrefs.GetInt("score").ToString();
    }
    public void OnClickStart()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
