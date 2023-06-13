using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject buttons;

    private void Awake()
    {
        buttons.SetActive(true);
        Time.timeScale = 0;
    }
}
