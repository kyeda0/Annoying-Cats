using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void Quit()
    {
        SceneManager.LoadScene("Menu Game");
    }
}
