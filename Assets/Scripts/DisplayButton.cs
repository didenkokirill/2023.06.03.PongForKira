using UnityEngine;

public class DisplayButton : MonoBehaviour
{
    public static DisplayButton Instanse;
  
    [SerializeField] private GameObject buttons;

    private void Awake() => Instanse = this;

    public void Display()
    {
        buttons.SetActive(true);
    }
}
