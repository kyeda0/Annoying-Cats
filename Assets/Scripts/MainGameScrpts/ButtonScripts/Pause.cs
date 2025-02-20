using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _panelPause;
    [SerializeField] private GameObject _mainPanell;

    public void Stop()
    {
        _panelPause.SetActive(true);
        _mainPanell.SetActive(false);
        Time.timeScale = 0f; 
    }
}
