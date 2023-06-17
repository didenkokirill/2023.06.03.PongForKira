using UnityEngine;

public class AI : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private Transform self;

    [SerializeField] private Rigidbody2D rigidBody;

    [SerializeField] private float speed = 5;

    private Vector2 direction;

    private void FixedUpdate()
    {
        Vector2 direction = Vector2.zero;

        if (ball.position.x < self.position.x - 0.1f)
        {
            direction = Vector2.left;
        }

        else if (ball.position.x > self.position.x + 0.1f)
        {
            direction = Vector2.right;
        }

        rigidBody.velocity = direction * speed;
    }
}
