using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider masterSlider;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;
    [SerializeField] Slider voiceSlider;

    const string MIXER_MASTER = "Master";
    const string MIXER_MUSIC = "Music";
    const string MIXER_SFX = "SFX";
    const string MIXER_VOICE = "Voice";


    private void Awake()
    {
        masterSlider.onValueChanged.AddListener(SetMasterVolume);
        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        sfxSlider.onValueChanged.AddListener(SetSFXVolume);
        voiceSlider.onValueChanged.AddListener(SetVoiceVolume);
    }
    public void SetMasterVolume(float volume)
    {
      
        audioMixer.SetFloat(MIXER_MASTER, Mathf.Log10(volume) * 20);
        audioMixer.SetFloat(MIXER_MUSIC, Mathf.Log10(volume) * 20);
        audioMixer.SetFloat(MIXER_SFX, Mathf.Log10(volume) * 20);
        audioMixer.SetFloat(MIXER_VOICE, Mathf.Log10(volume) * 20);
    }
   
    public void SetMusicVolume(float volume)
    { 
        audioMixer.SetFloat(MIXER_MUSIC, Mathf.Log10(volume) * 20);
    }

    public void SetSFXVolume(float volume)
    {      
        audioMixer.SetFloat(MIXER_SFX, Mathf.Log10(volume) * 20);
    }
    
    public void SetVoiceVolume(float volume)
    {       
        audioMixer.SetFloat(MIXER_VOICE, Mathf.Log10(volume) * 20);
    }
  
}
