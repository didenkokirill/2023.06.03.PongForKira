using UnityEngine;

public class DisplayButton : MonoBehaviour
{
    [SerializeField] private GameObject buttonClose, buttonRestart;
    [SerializeField] private GameObject canvas;

    public static DisplayButton Instanse;

    private void Awake()
    {
        Instanse = this;
    }

    public void Display()
    {
        GameObject close = Instantiate(buttonClose);
        close.transform.SetParent(canvas.transform, false);

        GameObject restart = Instantiate(buttonRestart);
        restart.transform.SetParent(canvas.transform, false);
    }
}
