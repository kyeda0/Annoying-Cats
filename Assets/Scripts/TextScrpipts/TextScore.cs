using UnityEngine;
using TMPro;
public class TextScore : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI _hightScoreText;
   [SerializeField] private TextMeshProUGUI _currentScoreText;
   public  int _currentScore = 0;
   [SerializeField] private int _hightScore = 0;


   private void Start(){
      _hightScore = PlayerPrefs.GetInt("AddScore");
   }

   public void Update(){
      ShowHightScore();
   }
   public void AddScore(){
      _currentScore++;
      _currentScoreText.GetComponent<TextMeshProUGUI>().text = _currentScore.ToString();
 }

   public void ShowHightScore(){

      if(_currentScore > _hightScore){
         _hightScore = _currentScore;
         _hightScoreText.GetComponent<TextMeshProUGUI>().text = _hightScore.ToString();
         PlayerPrefs.SetInt("AddScore",_hightScore);
         PlayerPrefs.Save();
      }
      else{ 
         _hightScoreText.GetComponent<TextMeshProUGUI>().text = _hightScore.ToString();
      }

   }
}
