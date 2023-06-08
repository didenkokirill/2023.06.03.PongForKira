using UnityEngine;

public class DisplayButton : MonoBehaviour
{
    public static DisplayButton Instanse;
  
    [SerializeField] private GameObject button;
    private void Awake() => Instanse = this;

    public void Display()
    {
        button.SetActive(true);
    }
}
