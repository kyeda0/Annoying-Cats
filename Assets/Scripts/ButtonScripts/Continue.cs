using UnityEngine;

public class Continue : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _panell;
    public void Coontinue()
    {
        _panel.SetActive(false);
        _panell.SetActive(true);
        Time.timeScale = 1f;
    }
}