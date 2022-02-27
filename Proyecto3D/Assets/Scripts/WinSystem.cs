using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSystem : MonoBehaviour
{
    public GameObject canvas;
    public GameObject text;
    public GameObject godmode;
    public AudioSource _as;

    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void OnTriggerEnter(Collider other)
    {
        _as.Play();
        canvas.SetActive(true);
        text.SetActive(false);
        godmode.SetActive(false);
        Time.timeScale = 0f;
    }
    
}
