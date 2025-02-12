using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SwapSprites : MonoBehaviour
{
    [SerializeField] private Sprite[] _spritePlayer;
    [SerializeField] private Text _countSprite;
    [SerializeField] private TextMeshProUGUI _priceText;
    [SerializeField] private SpriteRenderer _playerSpriteRenderer; 
    private int _currentSkinIndex;
    private int _price = 100;
    private int _thisCoins;
    private bool[] _purchasedSkins; 

    private void Awake()
    {
        _spritePlayer = Resources.LoadAll<Sprite>("Skins");
        _currentSkinIndex = PlayerPrefs.GetInt("SelectedSkinIndex", 0);
        _thisCoins = PlayerPrefs.GetInt("AddCoins", 0);
        _purchasedSkins = new bool[_spritePlayer.Length];
        for (int i = 0; i < _spritePlayer.Length; i++)
        {
            _purchasedSkins[i] = PlayerPrefs.GetInt($"SkinPurchased_{i}", i == 0 ? 1 : 0) == 1;
        }

        UpdateSkin();
    }

    private void Update()
    {
        _thisCoins = PlayerPrefs.GetInt("AddCoins", 0);
    }

    public void SwapSkinsRight()
    {
        _currentSkinIndex = (_currentSkinIndex + 1) % _spritePlayer.Length;
        UpdateSkin();
    }

    public void SwapSkinsLeft()
    {
        _currentSkinIndex--;
        if (_currentSkinIndex < 0) _currentSkinIndex = _spritePlayer.Length - 1;
        UpdateSkin();
    }

    public void EquipSkin()
    {
        if (_purchasedSkins[_currentSkinIndex])
        {
            PlayerPrefs.SetInt("SelectedSkinIndex", _currentSkinIndex);
            PlayerPrefs.Save();
        }
        else
        {
            if (_thisCoins >= _price)
            {
                _thisCoins -= _price;
                PlayerPrefs.SetInt("AddCoins", _thisCoins);
                PlayerPrefs.SetInt($"SkinPurchased_{_currentSkinIndex}", 1);
                PlayerPrefs.SetInt("SelectedSkinIndex", _currentSkinIndex);
                PlayerPrefs.Save();
                _purchasedSkins[_currentSkinIndex] = true;
            }
        }

        UpdateSkin();
    }

    private void UpdateSkin()
    {
        if (_spritePlayer.Length > 0)
        {
            _playerSpriteRenderer.sprite = _spritePlayer[_currentSkinIndex];
        }

        _countSprite.text = $"{_currentSkinIndex + 1}/{_spritePlayer.Length}";

        if (_purchasedSkins[_currentSkinIndex])
        {
            _priceText.text = "Equip";
        }
        else
        {
            _price = 100 * (_currentSkinIndex + 1);
            _priceText.text = $"Buy for {_price}";
        }
    }
}
