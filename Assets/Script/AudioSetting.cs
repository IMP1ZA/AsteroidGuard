using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    public void AdjustVolume(float slidervolume) 
    {
        _audioMixer.SetFloat("MasterVolume", Mathf.Log10(slidervolume) * 20f);
    }
}
