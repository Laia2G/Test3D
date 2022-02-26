using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMenu : MonoBehaviour
{
    //const string PPSonng = "PPSong";
    public AudioMixer audioMixer;
    public void SetLevel (float volume)
    {
        //Debug.Log(volume);
        //Debug.Log(Mathf.Log10(volume) * 20);
        audioMixer.SetFloat("Volumen", Mathf.Log10(volume) * 20);
    }
}
