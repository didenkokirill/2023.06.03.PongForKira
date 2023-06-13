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
        ai.SetActive(false);
        player2.SetActive(true);
        buttons.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnClickPlayWithAI()
    { 
        ai.SetActive(true);
        player2.SetActive(false);
        buttons.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnClickTrainMode()
    {
        ai.SetActive(false);
        player2.SetActive(false);
        topWall.SetActive(true);
        buttons.SetActive(false);
        Time.timeScale = 1;
    }
}
