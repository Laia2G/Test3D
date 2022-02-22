using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeathSystem : MonoBehaviour
{
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
    private void Muerte()
    {
        //Debug.Log("muerte");
        //enemiesCount++;
       //enemiesEnd.EndEnemies();
        //Debug.Log(enemiesCount);
        gameObject.SetActive(false);

    }
}