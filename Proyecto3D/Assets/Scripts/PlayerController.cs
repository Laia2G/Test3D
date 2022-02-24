using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    //public Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
      //  _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 2 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * -2 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Speed = 10;
        }
        else
        {
            Speed = 2;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Speed = 10;
        }
        else
        {
            Speed = 2;
        }
    }
}
