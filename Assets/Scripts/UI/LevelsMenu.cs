using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelsMenu : MonoBehaviour
{
    [SerializeField] int sceneName;
    SceneTransition transition;
    private void Start()
    {
        
    }
    public void OnClickStart()
    {
        transition = FindObjectOfType<SceneTransition>();
        if (transition != null)
        {
            transition.SceneLoader(sceneName);
        }
    }
}
