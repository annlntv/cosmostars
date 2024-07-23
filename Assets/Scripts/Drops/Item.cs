using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<ItemManager>().AddOne();
            Destroy(this.gameObject);
            PlayerPrefs.SetInt("score", FindObjectOfType<ItemManager>().numberOfItems);
        }
    }
}
