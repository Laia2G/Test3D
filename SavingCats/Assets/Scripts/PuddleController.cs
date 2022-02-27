using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuddleController : MonoBehaviour
{
    public float velocityMultiplyer;
    public ParticleSystem particle;
    private void OnTriggerStay(Collider other)
    {

        PlayerController playerSlow = other.GetComponent<PlayerController>();
        if (playerSlow)
        {
            playerSlow.velocityModifyer = velocityMultiplyer * playerSlow.Speed;
        }
        particle.Play();

    }

    private void OnTriggerExit(Collider other)
    {
        PlayerController playerSlow = other.GetComponent<PlayerController>();
        if (playerSlow)
        {
            playerSlow.velocityModifyer = 0;
        }
        particle.Stop();
    }
}
