using UnityEngine;
using TMPro;

public class TextCoins : MonoBehaviour
{

   public int _coins;
   [SerializeField] private  TextMeshProUGUI textcoin;

    private void Update(){
        textcoin.text = "Coins:"+ _coins;
        _coins = PlayerPrefs.GetInt("AddCoins");

    }
    public  void TakeCoins()
    {
        _coins +=100000;
        textcoin.text = "Coins:"+ _coins;
        PlayerPrefs.SetInt("AddCoins", _coins);
        PlayerPrefs.Save();
    }

}
