using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private GameObject _deathPanel;
    [SerializeField] private GameObject _mainPanel;
    Rigidbody2D _player;
    [SerializeField] private Sprite[] _spritePlayer;

    void Awake()
    {
        _player = GetComponent<Rigidbody2D>();
        _spritePlayer = Resources.LoadAll<Sprite>("Skins");
        int _selectSkinIndex = PlayerPrefs.GetInt("SelectedSkinIndex",0);
        if (_selectSkinIndex >= 0 && _selectSkinIndex < _spritePlayer.Length)
        {
            GetComponent<SpriteRenderer>().sprite = _spritePlayer[_selectSkinIndex];
        }
    }

    void Update()
    {
        if(Input.GetMouseButton(0)) 
        {
            Vector3 _tochPos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            if(_tochPos.x<0)
            {
                _player.velocity = Vector2.left * _moveSpeed;
            }
            else if(_tochPos.x >0)
            {
                _player.velocity = Vector2.right * _moveSpeed;    
            }

        }
        else
        {
            _player.velocity = Vector2.zero;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Block")
        {
            _deathPanel.SetActive(true);
            _mainPanel.SetActive(false);
            GameObject.FindGameObjectWithTag("TextScore").GetComponent<TextScore>().ShowHightScore();
            Time.timeScale = 0;
        }
    }
}
