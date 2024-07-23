using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WinPlayerBehavior : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.MoveTowards(0, transform.position.y, 0);
        float y = transform.position.y + Time.deltaTime * 5f;
        transform.position = new Vector3(x, y, 0);

        //transform.position = new Vector3(0, -6, 0);
    }
}
