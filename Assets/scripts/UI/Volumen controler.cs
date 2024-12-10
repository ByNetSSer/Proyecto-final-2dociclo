using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Volumencontroler : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        float savedVolume = PlayerPrefs.GetFloat("GameVolume", 0.35f);
        volumeSlider.value = savedVolume;
        AudioListener.volume = savedVolume;
        volumeSlider.onValueChanged.AddListener(SetVolumeSave);
    }
    public void SetVolumeSave(float volumen)
    {
        AudioListener.volume = volumen;
        PlayerPrefs.SetFloat("GameVolume", volumen);
    }
    
       
        

    
}
