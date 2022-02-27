using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeathSystem : MonoBehaviour
{
    void OnEnable()
    {
        GetComponent<Life>().OnDeath += Muerte;
    }

    void OnDisable()
    {
        GetComponent<Life>().OnDeath -= Muerte;
    }
    public virtual void Muerte()
    {
        gameObject.SetActive(false);

    }
}