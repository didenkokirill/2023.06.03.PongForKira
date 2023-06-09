using UnityEngine;

public class ChangeScore : MonoBehaviour
{
    [SerializeField, Range(1, 2)] private int PlayerID;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            ScoreManager.Instance.AddScore(PlayerID);
            MoveBall.Instance.ResetCoord();
        }
    }
}
