using UnityEngine;

public class BallMover : MonoBehaviour
{
    [SerializeField] private float velocityValue;
    private Rigidbody2D ballRigibody;

    private void Start()
    {
        ballRigibody = gameObject.GetComponent<Rigidbody2D>();
        ballRigibody.velocity = Vector2.down * velocityValue;
    }
}