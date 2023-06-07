using UnityEngine;

public class ChangeScore : MonoBehaviour
{
    [SerializeField, Range(1, 2)] int playerID;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Trigger");
            ScoreManager.Instance.AddScore(playerID);
            MoveBall.Instance.ResetCoord();
        }
    }
}
