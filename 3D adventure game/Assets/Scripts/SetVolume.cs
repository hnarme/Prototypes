using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixerGroup mixerGroup;

    // Start is called before the first frame update
    public void SetLevel(float sliderValue)
    {
        mixerGroup.audioMixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
    }

    public void SetSoundLevel(float sliderValue)
    {
        mixerGroup.audioMixer.SetFloat("SoundVolume", Mathf.Log10(sliderValue) * 20);
    }
}
