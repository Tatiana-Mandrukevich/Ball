using UnityEngine;

namespace DefaultNamespace
{
    public class WinScreenController : MonoBehaviour
    {
        [SerializeField] private GameObject _winScreen;
        
        private void Start()
        {
            _winScreen.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Ball"))
            {
                _winScreen.SetActive(true);
            }
        }
    }
}