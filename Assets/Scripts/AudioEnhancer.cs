using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioEnhancer : MonoBehaviour
{
    public Slider SpeedSlider;
    public Slider VolumeSlider;
    public AudioSource audioSource;

    private void Update()
    {
        audioSource.pitch = SpeedSlider.value;
        audioSource.volume = VolumeSlider.value;
    }

}
