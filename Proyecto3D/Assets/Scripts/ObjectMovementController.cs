using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovementController : MonoBehaviour
{
    public GameObject cars;
    public float velocity;
    //public Rigidbody _rb;

    
    /*void Update()
    {
        cars.GetComponent<Rigidbody>().AddForce(transform.right * velocity);
    }*/

    private void OnTriggerEnter(Collider other)
    {
        cars.GetComponent<Rigidbody>().AddForce(transform.right * velocity);
    }
}
