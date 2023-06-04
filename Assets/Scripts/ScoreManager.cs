using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int scorePlayer1;
    public int scorePlayer2;

    [SerializeField] TMP_Text score1Text;
    [SerializeField] TMP_Text score2Text;

    private void Awake()
    {
        Instance = this;
    }

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

        if (player == 2)
        {
            scorePlayer2++;
        }
    }
}
