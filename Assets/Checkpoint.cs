using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out BallCheckpointController newBall))
        {
            newBall.NewCheckpoint(transform.position);
            Destroy(gameObject);
        }
    }
}