using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] GameObject pickUpEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerMovement player = collision.GetComponent<PlayerMovement>();
            player.points++;
            Instantiate(pickUpEffect, transform.position, transform.rotation);
            Destroy(this.gameObject);
            PlayerPrefs.SetInt("score", player.points);

        }
    }
}
