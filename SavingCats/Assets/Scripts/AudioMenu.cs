using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetLevel (float volume)
    {
        audioMixer.SetFloat("Game", Mathf.Log10(volume) * 20);
    }
}
