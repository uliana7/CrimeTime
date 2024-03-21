using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public Sprite Audio_On;
    public Sprite Audio_Off;
    public GameObject button_audio;

    public AudioClip clip;
    public AudioSource audio;

    public void OnOffAudio()
    {
        if (AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            button_audio.GetComponent<Image>().sprite = Audio_Off;
        }
        else
        {
            AudioListener.volume = 1; 
            button_audio.GetComponent<Image>().sprite = Audio_On;
        }
    }
}