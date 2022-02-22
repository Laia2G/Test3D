using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovementController : MonoBehaviour
{
    public GameObject cars;
    public float velocity;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        cars.GetComponent<Rigidbody2D>().AddForce(transform.right * velocity);
    }
}
