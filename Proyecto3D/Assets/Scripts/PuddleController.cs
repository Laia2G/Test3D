using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuddleController : MonoBehaviour
{
    public float velocityMultiplyer;
    private void OnTriggerStay(Collider other)
    {
        PlayerController playerSlow = other.GetComponent<PlayerController>();
        if (playerSlow)
        {
            playerSlow.velocityModifyer = velocityMultiplyer * playerSlow.Speed;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerController playerSlow = other.GetComponent<PlayerController>();
        if (playerSlow)
        {
            playerSlow.velocityModifyer = 0;
        }
    }
}
