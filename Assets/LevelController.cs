using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class LevelController : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Ball"))
            {
                Invoke("LoadNextLevel", 5f);
            }
        }

        private void LoadNextLevel()
        {
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            int nextIndex = currentIndex + 1;
            if (nextIndex < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(nextIndex);
            }
        }
    }
}