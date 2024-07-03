using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelsMenu : MonoBehaviour
{
    [SerializeField] string sceneName;

    public void OnClickStart()
    {
        if (sceneName != null)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
