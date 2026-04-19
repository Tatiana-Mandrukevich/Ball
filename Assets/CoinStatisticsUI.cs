using System;
using TMPro;
using UnityEngine;

public class CoinStatisticsUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsNumber;
    
    private int _totalCoins;

    private void Start()
    {
        _totalCoins = 0;
        ShowActualTotalCoins();
    }

    public void AddCoin()
    {
        _totalCoins++;
        ShowActualTotalCoins();
    }

    private void ShowActualTotalCoins()
    {
        _coinsNumber.text = _totalCoins.ToString();
    }
}