using UnityEngine;

public class AI : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private Transform self;

    [SerializeField] Rigidbody2D rigidBody;

    [SerializeField] private float speed = 5;
    [SerializeField] private int difficult = 5; //control AI bezumie

    private Vector2 direction;

    private int frame;

    private void Update()
    {
        frame++;
    
        if (frame >= difficult) //for controll AI speed, try set difficult = 0
        {
            if (ball.position.x < self.position.x)
            {
                direction = Vector2.left;
            }

            if (ball.position.x > self.position.x)
            {
                direction = Vector2.right;
            }

            frame = 0;
        }

        rigidBody.velocity = direction * speed;
    }
}
