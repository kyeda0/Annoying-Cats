using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _scoreText;
    [SerializeField] private GameObject _coinsText;
    public GameObject[] _panels;

    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void StartGame(){
        GameObject.FindGameObjectWithTag("SpawnPoint").GetComponent<SpawnBlocks>().StartSpawning();
        _player.transform.position = new Vector3(0f, -4.08f,0f);
        _scoreText.SetActive(true);
        _coinsText.SetActive(true);
    }
}
