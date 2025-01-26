using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    private  AudioSource _audio;
    private  float _musicVol;
    [SerializeField] private Slider _slider;
    private  void Start()
    {
        _audio = GetComponent<AudioSource>();
        _musicVol =  PlayerPrefs.GetFloat("Audio");  
        _slider.value = PlayerPrefs.GetFloat("Slider");  
    }
    void Update()
    {
        _audio.volume = _musicVol;  
        SetVol(_audio.volume); 
        PlayerPrefs.SetFloat("Audio", _musicVol);
        PlayerPrefs.SetFloat("Slider",_slider.value);
        PlayerPrefs.Save();
    }
    public void SetVol(float _volume)
    {
        _musicVol = _volume;
    }
}
