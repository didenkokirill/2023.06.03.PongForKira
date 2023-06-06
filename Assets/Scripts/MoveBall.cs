using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public static MoveBall Instance;

    [SerializeField] Rigidbody2D rigidBody;

    [SerializeField] private Vector2 direction;

    [SerializeField] private float baseSpeed = 3f, currentSpeed, scaleSpeed = 1.1f;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        currentSpeed = baseSpeed;
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));   
    }

    private void Update()
    {
         rigidBody.velocity = direction.normalized * currentSpeed;

         if (Input.anyKey)
        {
             Time.timeScale = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            direction.x = -direction.x;
            currentSpeed *= scaleSpeed;
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

    public void ResetCoord()
    {
        transform.position = Vector3.zero;
        currentSpeed = baseSpeed;
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));

        if (!Input.anyKey)
        {
            Time.timeScale = 0;
        }
    }
}
