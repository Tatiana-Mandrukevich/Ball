using UnityEngine;

public class BallCheckpointController : MonoBehaviour
{
    public Vector3 LastCheckpoint;

    private void Start()
    {
        LastCheckpoint = transform.position;
    }
    
    public void ReturnToLastCheckpoint()
    {
        transform.position = LastCheckpoint;
    }
    
    public void NewCheckpoint(Vector3 point)
    {
        LastCheckpoint = point;
    }
}