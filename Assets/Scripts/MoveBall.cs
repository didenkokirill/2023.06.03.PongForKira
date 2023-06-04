using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] private float speed;
    [SerializeField] private Vector2 direction;
    
    private void Start()
    {
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(-0.5f, -1));
    }
    void Update()
    {
        rigidBody.velocity = direction.normalized * speed;
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            direction.x = -direction.x;
        }
        if (collision.gameObject.CompareTag("TopWall"))
        {
            direction.y = -direction.y;
        }
        if (collision.gameObject.CompareTag("BottomWall"))
        {
            direction.y = -direction.y;
        }
    }
}
