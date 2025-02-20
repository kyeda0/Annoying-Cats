using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    public void restart()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }
}
