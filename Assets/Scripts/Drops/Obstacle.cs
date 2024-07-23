using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float rotationMax = 180f;
    [SerializeField] float rotationMin = 0f;
    [SerializeField] float scaleMax = 1.3f;
    [SerializeField] float scaleMin = 0.7f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
    private void Start()
    {
        randomSize();
        randomRotation();
    }

    void randomSize()
    {
        float scaleFactor = Random.Range(scaleMin, scaleMax);
        transform.localScale = (Vector2)transform.localScale * scaleFactor;
    }


    void randomRotation()
    {
        float rotationFactor = Random.Range(rotationMin, rotationMax);
        transform.localEulerAngles = Vector3.forward * rotationFactor;
    }
}
