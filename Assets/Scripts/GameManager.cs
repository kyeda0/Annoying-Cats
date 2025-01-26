using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private AudioSource _music;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _scoreText;
    [SerializeField] private Animator _animatorRule;

    private void Start()
    {
        _music.Pause();
        gameObject.SetActive(true);
        _animatorRule.SetBool("StartRule",true);
        Time.timeScale = 1f;
    }
    public void StartGame(){
        _music.Play();
        GameObject.FindGameObjectWithTag("SpawnPoint").GetComponent<SpawnBlocks>().StartSpawning();
        _player.transform.position = new Vector3(0f, -4.06f,0f);
        _scoreText.SetActive(true);
        gameObject.SetActive(false);
        _animatorRule.SetBool("StartRule",false);
    }
}
