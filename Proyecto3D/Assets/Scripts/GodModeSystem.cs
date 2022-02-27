using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GodModeSystem : MonoBehaviour
{
    public static bool lifeInmortal;
    public GameObject cat;
    public GameObject player;
    public int cats = 0;
    public void AddLife()
    {      
        if (!lifeInmortal)
        {
            lifeInmortal = true;
        }
        else
        {
            lifeInmortal = false;
        }
    }

    public void AddCat()
    {
        if (cats <= 2)
        {
            Instantiate(cat, player.transform.position, player.transform.rotation);
            cats++;
        }        
    }
}
