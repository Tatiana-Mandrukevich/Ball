using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private CoinStatisticsUI _coinStatisticsUI;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            _coinStatisticsUI.AddCoin();
        }
    }
}