using UnityEngine;

public class Continue : MonoBehaviour
{
    [SerializeField] private GameObject _panelPause;
    [SerializeField] private GameObject _mainPanell;
    public void Coontinue()
    {
        _panelPause.SetActive(false);
        _mainPanell.SetActive(true);
        Time.timeScale = 1f;
    }
}