using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenAndCloseShop : MonoBehaviour
{
    public void OpenShop(){
        SceneManager.LoadScene("Shop");
    }   

    public void CloseShop(){
        SceneManager.LoadSceneAsync("Menu Game");
    }
}
