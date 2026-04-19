using UnityEngine;

public class KillTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out BallCheckpointController checkpointController))
        {
            checkpointController.ReturnToLastCheckpoint();
        }
    }
}