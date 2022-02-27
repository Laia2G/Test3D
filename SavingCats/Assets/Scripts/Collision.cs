using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collision : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter(Collider other)
    {
        Life hitdamage = other.gameObject.GetComponent<Life>();
        hitdamage?.Quitarvida(damage);
    }
}