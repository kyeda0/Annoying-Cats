using TMPro;
using UnityEngine;

public class AnimatorOnOff : MonoBehaviour
{
    [SerializeField] private Animator _animatorRule;
    [SerializeField] private TextMeshProUGUI _text;
     private void Start()
    {
        StartRule();
    }

    public void OffAnimators()
    {
        _animatorRule.SetBool("StartRule",false);
        _animatorRule.gameObject.SetActive(false);
        GameObject.FindWithTag("GameController").GetComponent<GameManager>().StartGame();
    }

    public void StartRule()
    {
        _animatorRule.gameObject.SetActive(true);
        _animatorRule.SetBool("StartRule",true);
    }

    public void ChangeText(){
        _text.text = "Dodeg and\n collect coins";
        _text.fontSize = 80;
    }

}
