using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    [SerializeField] private int scorePlayer1, scorePlayer2, ScoreForWin = 5;

    [SerializeField] TMP_Text score1Text, score2Text, resultsText;

    private void Awake() => Instance = this;
    
    private void Update()
    {
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

        if (scorePlayer1 >= ScoreForWin)
        {
            resultsText.text = "Player 1 Win";
            DisplayButton.Instanse.Display();
        }

        else (scorePlayer2 >= ScoreForWin)
        {
            resultsText.text = "Player 2 Win";
            DisplayButton.Instanse.Display();
        }

        score1Text.text = $"{scorePlayer1}";
        score2Text.text = $"{scorePlayer2}";
    }
}
