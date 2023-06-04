using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] private float speed;
    [SerializeField] private KeyCode up;
    [SerializeField] private KeyCode down;

    void Update()
    {
        Vector2 direction = Vector2.zero;
        if (Input.GetKey(up))
        {
            direction = Vector2.up;
        }

        if (Input.GetKey(down))
        { 
            direction = Vector2.down; 
        }
        rigidBody.velocity = direction * speed;
    }   
}
