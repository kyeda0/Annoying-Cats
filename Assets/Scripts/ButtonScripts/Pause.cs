using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _panell;

    public void Stop()
    {
        _panel.SetActive(true);
        _panell.SetActive(false);
        Time.timeScale = 0f; 
    }
}
