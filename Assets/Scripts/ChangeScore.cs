using UnityEngine;

public class ChangeScore : MonoBehaviour
{
    [SerializeField, Range(1, 2)] private int playerID;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            ScoreManager.Instance.AddScore(playerID);

            MoveBall.Instance.ResetCoord();
        }        
    }
}
