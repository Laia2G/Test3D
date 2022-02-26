using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeathSystem : MonoBehaviour
{
    public Canvas canvas;
    //public EnemiesEndSystem enemiesEnd;
    //public static int enemiesCount;
    void OnEnable()
    {
        GetComponent<Life>().OnDeath += Muerte;
        //GetComponent<BalasSystem>().OnDeath2 += Muerte;
    }

    void OnDisable()
    {
        GetComponent<Life>().OnDeath -= Muerte;
        //GetComponent<BalasSystem>().OnDeath2 -= Muerte;
    }
    public virtual void Muerte()
    {
        //Debug.Log("muerte");
        //enemiesCount++;
       //enemiesEnd.EndEnemies();
        //Debug.Log(enemiesCount);
        gameObject.SetActive(false);
        //canvas.GetComponent<MenuController>().Game_Over();

    }
}