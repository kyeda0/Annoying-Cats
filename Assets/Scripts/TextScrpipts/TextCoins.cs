using UnityEngine;
using TMPro;

public class TextCoins : MonoBehaviour
{

   private static int coins = 0;
   [SerializeField] private static TextMeshProUGUI textcoin;


    public static void TakeCoins()
    {
        coins++;
        textcoin.text = "Coins" + coins;
    }

}
