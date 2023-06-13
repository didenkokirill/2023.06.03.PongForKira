using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickButton : MonoBehaviour
{
    [SerializeField] private GameObject ai, player2, topWall, buttons;

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

    private void SetAI(bool isAI, bool isPLayer2, bool isButtons)
    {
        ai.SetActive(isAI);
        player2.SetActive(isPLayer2);
        buttons.SetActive(isButtons);
        Time.timeScale = 1;
    }
}
