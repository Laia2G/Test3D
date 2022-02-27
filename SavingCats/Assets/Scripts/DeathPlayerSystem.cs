using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlayerSystem : DeathSystem
{
    public Canvas canvas;
    public override void Muerte()
    {
        canvas.GetComponent<MenuController>().Game_Over();
    }
}
