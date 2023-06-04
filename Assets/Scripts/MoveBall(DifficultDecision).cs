using UnityEngine;

public class MoveBallDif : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] private float speed;
    [SerializeField] private Vector2 direction;
    public Vector2 angleOfCollision;
    public float angleBeweenObjects;

    
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
        angleOfCollision = new Vector2 (collision.transform.position.x , collision.transform.position.y);
        angleBeweenObjects = Vector2.Angle(angleOfCollision, direction);
        
        if (collision != null)
        {
            Vector2.Reflect(angleOfCollision, direction);
        }
    }
}
