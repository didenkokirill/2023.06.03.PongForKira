using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickButton : MonoBehaviour
{
    [SerializeField] private GameObject ai, player2, topWall, buttonsStartGame;

    public void OnClickRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void OnClickClose()
    {
        Application.Quit();
    }

    public void OnClickTwoPlayers()
    {
        SetAI(false, true, false);
    }

    public void OnClickPlayWithAI()
    {
        SetAI(true, false, false);
    }

    public void OnClickTrainMode()
    {
        SetAI(false, false, false);
        topWall.SetActive(true);
    }

    private void SetAI(bool isAI, bool isPLayer2, bool isButtonsStartGame)
    {
        ai.SetActive(isAI);
        player2.SetActive(isPLayer2);
        buttonsStartGame.SetActive(isButtonsStartGame);
        Time.timeScale = 1;
    }
}
