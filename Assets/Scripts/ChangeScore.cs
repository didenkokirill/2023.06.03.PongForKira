using UnityEngine;

public class ChangeScore : MonoBehaviour
{
    [SerializeField] private int player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (player == 1)
            {
                ScoreManager.Instance.AddScore(2);
            }
            if (player == 2)
            {
                ScoreManager.Instance.AddScore(1);
            }

            MoveBall.Instance.ResetCoord();
            Debug.Log("м€ч попал в зону очков");
        }        
    }
}
