using System;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class WinScreen : MonoBehaviour
    {
        [SerializeField] private TMP_Text _coinsNumber;
        [SerializeField] private CoinStatisticsUI _coinStatisticsUI;

        private void Start()
        {
            _coinsNumber.text = _coinStatisticsUI.TotalCoins.ToString();
        }
    }
}