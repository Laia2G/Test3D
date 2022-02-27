using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovementController : MonoBehaviour
{
    public GameObject cars;
    public float velocity;
    private void OnTriggerEnter(Collider other)
    {
        cars.SetActive(true);
        cars.GetComponent<Rigidbody>().AddForce(transform.right * velocity);
    }
}
