using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapUI : MonoBehaviour
{
    public void OnClickToStartScreen()
    {
        SceneTransition transition = FindObjectOfType<SceneTransition>();
        transition.SceneLoader(0);
    }
}
