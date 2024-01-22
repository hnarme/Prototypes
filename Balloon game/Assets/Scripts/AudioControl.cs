using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour
{
    public AudioSource bckgrndMusic;
    public Toggle isToggleActive;

    // Start is called before the first frame update
    void Start()
    {
        bckgrndMusic = GetComponent<AudioSource>();
        bckgrndMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        ButtonHandlerMusic();
    }

    public void ButtonHandlerMusic()
    {
        if (isToggleActive.isOn)
        {
            bckgrndMusic.UnPause();
        }
        else
        {
            bckgrndMusic.Pause();
        }
    }
}
