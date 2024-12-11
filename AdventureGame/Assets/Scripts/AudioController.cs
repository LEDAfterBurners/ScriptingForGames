using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
[RequireComponent(typeof(AudioSource))]
public class AudioController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    
    private AudioSource audioSource;
    
    audioSource = GetComponent<AudioSource>();
    audioSource.Play();
    
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            audioSource.UnPause();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            audioSource.Pause();
        }
    }
}
**/