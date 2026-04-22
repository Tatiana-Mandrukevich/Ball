using TMPro;
using UnityEngine;

public class CoinStatisticsUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsNumber;
    
    public int TotalCoins { get; private set; }

    private void Start()
    {
        ShowActualTotalCoins();
    }

    public void AddCoin()
    {
        TotalCoins++;
        ShowActualTotalCoins();
    }

    private void ShowActualTotalCoins()
    {
        _coinsNumber.text = TotalCoins.ToString();
    }
}