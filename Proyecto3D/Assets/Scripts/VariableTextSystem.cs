using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VariableTextSystem : MonoBehaviour
{
    public static event Action<float> OnTexto = delegate { };
    void OnEnable()
    {
        GetComponent<Life>().OnMandar += RecibirVariable;
    }
    void OnDisable()
    {
        GetComponent<Life>().OnMandar -= RecibirVariable;
    }
    public void RecibirVariable(float vida)
    {
        OnTexto(vida);
    }

}
