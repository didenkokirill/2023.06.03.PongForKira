using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public static MoveBall Instance;

    [SerializeField] Rigidbody2D rigidBody;

    [SerializeField] private Vector2 direction;

    [SerializeField] public bool paused = false;

    [SerializeField] private float baseSpeed = 3f, currentSpeed, scaleSpeed = 1.1f;

    private void Awake() => Instance = this;

    private void Start()
    {
        currentSpeed = baseSpeed;
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));   
    }

    private void Update()
    {
        rigidBody.velocity = direction.normalized * currentSpeed;

        if (paused & Input.anyKeyDown) 
        {
            Time.timeScale = 1;
            paused = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            direction.x = -direction.x;
            currentSpeed *= scaleSpeed;
        }
        else if (collision.gameObject.CompareTag("TopWall"))
        {
<<<<<<< Updated upstream
            direction.y = -direction.y;
        }
        else if (collision.gameObject.CompareTag("BottomWall"))
        {
            direction.y = -direction.y;
        }      
=======
            direction.x = -direction.x;
        }
        else if (collision.gameObject.CompareTag("TopWall")) //for train mode
        {
            direction.y = -direction.y;
        }
>>>>>>> Stashed changes
    }

    public void ResetCoord()
    {
        transform.position = Vector3.zero;
        currentSpeed = baseSpeed;
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));
        
        Time.timeScale = 0;
        paused = true;       
    }
}
