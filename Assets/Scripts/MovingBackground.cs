using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float speed;

    [SerializeField]
    private Renderer bgRenderer;

    void FixedUpdate()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
    }
}
