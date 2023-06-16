using System.Collections;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public static MoveBall Instance;

    [SerializeField] Rigidbody2D rigidBody;

    [SerializeField] private Vector2 direction;

    [SerializeField] public bool pausedMove = false;

    [SerializeField] private float respawnDelay = 0.3f;

    [SerializeField] private float baseSpeed = 3f, currentSpeed, scaleSpeed = 1.1f;

    private void Awake() => Instance = this;

    private void Start()
    {
        currentSpeed = baseSpeed;
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));


    }

    private void FixedUpdate()
    {
        rigidBody.velocity = direction.normalized * currentSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            direction.y = -direction.y;
            currentSpeed *= scaleSpeed;
        }
        else if (collision.gameObject.CompareTag("SideWall"))
        {
            direction.x = -direction.x;
        }
        else if (collision.gameObject.CompareTag("TopWall"))
        {
            direction.y = -direction.y;
        }
    }

    public void ResetCoord()
    {
        transform.position = Vector3.zero;
        currentSpeed = baseSpeed;
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));

        PauseTime();

        if (pausedMove == false)
        {
            StartCoroutine(Delay());      
        }
    }

    IEnumerator Delay()
    {
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(respawnDelay);
        Time.timeScale = 1;
    }

    private void PauseTime()
    {
        GameObject go = GameObject.Find("SceneManager");
        DisplayButton paused = go.GetComponent<DisplayButton>(); //pipes kakoi kastily
        if (paused == true)
        {
            pausedMove = true;
        }
    }
}
