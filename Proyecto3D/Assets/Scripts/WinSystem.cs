using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSystem : MonoBehaviour
{
    public GameObject canvas;

    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
        Time.timeScale = 0f;
    }
    
}
