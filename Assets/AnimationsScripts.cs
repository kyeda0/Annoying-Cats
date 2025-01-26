using UnityEngine;

public class AnimationsScripts : MonoBehaviour
{
   [SerializeField] public Animator _animatorImage;
   [SerializeField] public Animator _animatorPlayer;

   [SerializeField] private Sprite[] _spritePlayer;
   [SerializeField] private GameObject _player;


   private void Start(){
      StartAnimation();
       _spritePlayer = Resources.LoadAll<Sprite>("Skins");

      int _selectSkinIndex = PlayerPrefs.GetInt("SelectedSkinIndex",0);
      if (_selectSkinIndex >= 0 && _selectSkinIndex < _spritePlayer.Length)
      {
         _player.GetComponent<SpriteRenderer>().sprite = _spritePlayer[_selectSkinIndex];
      }
   }

 private  void StartAnimation(){
    _animatorImage.SetBool("Start",true);
    _animatorPlayer.SetBool("StartPlayer",true);
 }

}
