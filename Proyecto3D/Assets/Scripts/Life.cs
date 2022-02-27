using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    
    public event Action OnDeath = delegate { };
    public event Action<float> OnMandar = delegate { };
    private float timer = 10f;
    private Animator _anim;
    public float vida;
    void Start()
    {
        OnMandar(vida);
        _anim = GetComponentInChildren<Animator>();
    }
    private void Update()
    {
        timer--;
    }

    public void Quitarvida(float damage)
    {
        if (GodModeSystem.lifeInmortal == false)
        {
            vida = vida - damage;
            OnMandar(vida);
            timer = 10f;
        }            
        
        if (vida <= 0)
        {
            vida = 0;
            
            OnMandar(vida);
            OnDeath();
        }

    }

    public void AddLIFE(float getlife)
    {
        vida = vida + getlife;
    }
}