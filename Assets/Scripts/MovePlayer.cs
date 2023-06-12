using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody;

    [SerializeField] private float speed;

    [SerializeField] private KeyCode left;
    [SerializeField] private KeyCode right;

    private void Update()
    {
        Vector2 direction = Vector2.zero;

        if (Input.GetKey(left))
        {
            direction = Vector2.left;
        }

        if (Input.GetKey(right))
        { 
            direction = Vector2.right; 
        }

        rigidBody.velocity = direction * speed;
    }   
}
