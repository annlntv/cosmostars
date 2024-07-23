using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] ItemManager itemManager;
    [SerializeField] Sprite playerSprite;
    [SerializeField] int price;

    public void BuySkin()
    {
        if (itemManager.numberOfItems >= price)
        {
            itemManager.SpendMoney(price);
            Progress.Instance.Items = itemManager.numberOfItems;
            
        }
    }
}
