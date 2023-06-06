using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    [SerializeField] private int scorePlayer1, scorePlayer2;

    [SerializeField] private TMP_Text score1Text, score2Text;

    private void Awake()
    {
        Instance = this;
        score1Text.text = $"{scorePlayer1}";
        score2Text.text = $"{scorePlayer2}";
    }

    public void AddScore(int player)
    {
        if (player == 1)
        {
            scorePlayer1++;
        }
        else if (player == 2)
        {
            scorePlayer2++;
        }

        score1Text.text = $"{scorePlayer1}";
        score2Text.text = $"{scorePlayer2}";
    }
}
