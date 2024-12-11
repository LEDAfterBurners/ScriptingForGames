using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    private float tempVal;
    bool muted = false;

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    
    private void Save()
    {
        if (muted == false)
        {
            PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
            tempVal = volumeSlider.value;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (muted == false)
            {
                muted = true;
                volumeSlider.value = 0.001f;
            }
            else
            {
                muted = false;
                volumeSlider.value = tempVal;
            }
        }
    }
}