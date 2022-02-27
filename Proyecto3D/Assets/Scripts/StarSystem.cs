using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StarSystem : MonoBehaviour
{
    public static int starCount = 0;
    public AudioSource _as;
    public static event Action<int> OnTexto = delegate { };
    private void Start()
    {
        starCount = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        _as.Play();
        starCount++;
        OnTexto(starCount);
        gameObject.SetActive(false);
    }
}
