using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerMovement player = collision.GetComponent<PlayerMovement>();
            player.points++;
            Destroy(this.gameObject);
            PlayerPrefs.SetInt("score", player.points);
        }
    }
}
