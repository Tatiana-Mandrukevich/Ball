using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallController : MonoBehaviour
{
    public CustomButton Right;
    public CustomButton Left;
    public CustomButton Jump;
    public float MaxSpeed = 4;
    public float JumpForce = 7;
    public float Radius;
    public Transform GroundTarget;
    public LayerMask GroundLayer;
    public bool IsGround;
    
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        IsGround = IsGrounded();
        if (Mathf.Abs(_rigidbody2D.velocity.x) < MaxSpeed)
        {
            if (Right.IsPressed)
            {
                _rigidbody2D.AddForce(Vector2.right);
            }
        
            if (Left.IsPressed)
            {
                _rigidbody2D.AddForce(Vector2.left);
            }
        }

        if (IsGround && Jump.IsButtonDown)
        {
            _rigidbody2D.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }
    }

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(GroundTarget.position, Radius, GroundLayer);
    }

    private void OnDrawGizmosSelected()
    {
        if (GroundTarget == null) return;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(GroundTarget.position, Radius);
    }
}