using UnityEngine;

public class DisplayButton : MonoBehaviour
{
    public static DisplayButton Instanse;
  
<<<<<<< Updated upstream
    [SerializeField] private GameObject button;
=======
    [SerializeField] private GameObject buttonsEndGame;
>>>>>>> Stashed changes

    private void Awake() => Instanse = this;

    public void DisplayEndGame()
    {
<<<<<<< Updated upstream
        button.SetActive(true);
=======
        buttonsEndGame.SetActive(true) ;
>>>>>>> Stashed changes
    }
}
