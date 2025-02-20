using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
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
        Move();
    }

    private void Move(){

        Vector3 _tochPos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetMouseButton(0)) 
        {
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
}
