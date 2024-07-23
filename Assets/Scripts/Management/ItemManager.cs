using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemManager : MonoBehaviour
{
    public int numberOfItems;
    [SerializeField] TextMeshProUGUI text;

    private void Start()
    {
        numberOfItems = Progress.Instance.Items;
        text.text = numberOfItems.ToString();
    }

    public void AddOne()
    {
        numberOfItems++;
        print(numberOfItems.ToString());
        text.text = numberOfItems.ToString();
        print(text.text);
    }

    public void SaveToProgress()
    {
        Progress.Instance.Items = numberOfItems;
    }

    public void SpendMoney(int value)
    {
        numberOfItems -= value;
        text.text = numberOfItems.ToString();
    }
}