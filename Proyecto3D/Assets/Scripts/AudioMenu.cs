using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMenu : MonoBehaviour
{
    //const string PPSonng = "PPSong";
    public AudioMixer audioMixer;
   //public Slider slider;
    public void SetLevel (float volume)
    {
        //Debug.Log(volume);
        //Debug.Log(Mathf.Log10(volume) * 20);
        audioMixer.SetFloat("Game", Mathf.Log10(volume) * 20);
        //Debug.Log("Game");
    }
}
