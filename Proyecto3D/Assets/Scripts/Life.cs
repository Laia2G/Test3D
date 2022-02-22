using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    //public ParticleSystem particulas;
    //int Damages;
    
    public event Action OnDeath = delegate { };
    public event Action<float> OnMandar = delegate { };
    private float timer = 10f;
    private Animator _anim;
    //private ControlarMenu _CM;
    //public Text textovidas;
    //public int vidaMax = 100;
    public float vida;
    void Start()
    {
        OnMandar(vida);
        _anim = GetComponentInChildren<Animator>();
        //_CM = GetComponent<ControlarMenu>();
    }
    private void Update()
    {
        timer--;
    }

    public void Quitarvida(float damage)
    {
        //Debug.Log("antes de vida 0");
        //if (timer <= 0)
        
            vida = vida - damage;
            OnMandar(vida);
            timer = 10f;
        
        if (vida <= 0)
        {
            //Debug.Log("vida 0");
            vida = 0;
            
            OnMandar(vida);
            OnDeath();
            
            //_CM.Game_Over();
            //_anim.SetBool("die", true);
        }

    }

    /*public void Darvida(int heal)
    {
        vida += heal;
        OnMandar(vida);
        if (vida > vidaMax)
        {
            vida = vidaMax;
            OnMandar(vida);
        }

    }*/
}