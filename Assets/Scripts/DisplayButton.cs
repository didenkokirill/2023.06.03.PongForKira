using UnityEngine;

public class DisplayButton : MonoBehaviour
{
    public static DisplayButton Instanse;
  
    [SerializeField] private GameObject buttonsEndGame;

    private void Awake() => Instanse = this;

    public void DisplayEndGame()
    {
        buttonsEndGame.SetActive(true);
    }
}
