using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collision : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter2D(Collider2D other)
    {
        //if(other.gameObject.GetComponent<Life>() != null)
        Life hitdamage = other.gameObject.GetComponent<Life>();
        hitdamage?.Quitarvida(damage);
    }
}