using UnityEngine;

public class DisplayButton : MonoBehaviour
{
    public static DisplayButton Instanse;
  
    [SerializeField] private GameObject buttonsEndGame;
    public bool paused = false;

    private void Awake() => Instanse = this;

    public void DisplayEndGame()
    {
        buttonsEndGame.SetActive(true);
        paused = true;
        Time.timeScale = 0;
    }
}
