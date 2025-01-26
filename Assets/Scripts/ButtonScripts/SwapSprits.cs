using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SwapSprits : MonoBehaviour
{
   [SerializeField] private  Sprite[] _spritePlayer;
   [SerializeField] private Text _countSprite;
    private static int _currentCountSprits = -1;
    private static float _currentCount;

   private void Awake(){
      _currentCount = 1;
      _currentCountSprits = 0;
      _spritePlayer = Resources.LoadAll<Sprite>("Skins");
   }
   private void Update(){
      _countSprite.text = $"{_currentCount}/{_spritePlayer.Length - 1}";
   }
   public void SwapSkinsRight(){
      if(_currentCountSprits == _spritePlayer.Length - 1){
      _currentCountSprits = -1;
      _currentCount = 0;
    }
    _currentCountSprits++;
    _currentCount++;
    GetComponent<SpriteRenderer>().sprite = _spritePlayer[_currentCountSprits]; 
   }
   public void SwapSkinsLeft(){
      if(_currentCountSprits == 0 || _currentCountSprits == -1){
        _currentCount = _spritePlayer.Length;
        GetComponent<SpriteRenderer>().sprite = _spritePlayer.Last();
        _currentCountSprits = _spritePlayer.Length;
      }
      _currentCountSprits--;
      _currentCount--;
      GetComponent<SpriteRenderer>().sprite = _spritePlayer[_currentCountSprits]; 
      Debug.Log(_currentCountSprits);
   }

   public void EqipSkin(){
      PlayerPrefs.SetInt("SelectedSkinIndex",_currentCountSprits);
      PlayerPrefs.Save();
   }
}
