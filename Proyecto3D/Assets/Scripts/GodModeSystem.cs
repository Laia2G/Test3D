using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GodModeSystem : MonoBehaviour
{
    public GameObject cats;
    public Transform emptyCat;
    public event Action<float> OnLife = delegate { };

    public void AddCats()
    {
        EmptyCats _hollowCat = cats.GetComponent<EmptyCats>();
        if (_hollowCat)
        {
            //emptyCat = _hollowCat.AddCat(cats);
        }
    }
    public void AddLife()
    {
        OnLife(100);
    }
}
