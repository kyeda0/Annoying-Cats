using TMPro;
using UnityEngine;

public class ButtonSettings : MonoBehaviour
{
    [SerializeField] private GameObject _settingsGameObjects;
    private bool _onSettings = true;
    public void OnSettingsVol()
        {
            if(_onSettings == true)
            {
                _settingsGameObjects.SetActive(true);
                _onSettings = false;
            }
            else if(_onSettings == false)
            {
                _settingsGameObjects.SetActive(false);
                _onSettings = true;

            }
     } 
}
