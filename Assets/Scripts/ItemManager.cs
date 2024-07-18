using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
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
        text.text = numberOfItems.ToString();
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