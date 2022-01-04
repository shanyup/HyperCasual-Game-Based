using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketManager : MonoBehaviour
{
    private int productPrice;
    private int currentGoldInt;

    private Ch_Stats _chStats;
    private void Start()
    {
        _chStats = FindObjectOfType<Ch_Stats>();
    }

    public void Buy(int price)
    {
        if (_chStats.goldInt > price)
        {
            currentGoldInt = _chStats.goldInt - price;
            Debug.Log("Satın alındı.");
        }
        else
        {
            Debug.Log("Para yetmedi be abi");
        }
    }
}
