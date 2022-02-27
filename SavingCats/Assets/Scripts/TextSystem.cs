using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TextSystem : MonoBehaviour
{
    public Text[] variable;

    public event Action<float> OnVariable = delegate { };

    void OnEnable()
    {
        StarSystem.OnTexto += Texto;
    }
    void OnDisable()
    {
        StarSystem.OnTexto -= Texto;

    }
    private void Texto(int starCount)
    {
        for (int i = 0; i < variable.Length; i++)
        {
            variable[i].text = " " + starCount;
        }        
    }
}
