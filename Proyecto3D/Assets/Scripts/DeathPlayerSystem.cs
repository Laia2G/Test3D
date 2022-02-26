using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlayerSystem : DeathSystem
{
    public override void Muerte()
    {
        //gameObject.SetActive(false);
        canvas.GetComponent<MenuController>().Game_Over();
    }
}
