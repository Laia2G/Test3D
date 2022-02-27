using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public float velocity;
    public float velocityModifyer;
    public Rigidbody _rb;
    public LayerMask groundPlayer;
    public Transform groundChecker;
    public float GCradius;
    public AudioSource _as;
    void Start()
    {
      _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 vel = _rb.velocity;
        vel = new Vector3(vel.x, vel.y, (velocityModifyer + Speed));


        if (Input.GetKey(KeyCode.D))
        {
            vel = new Vector3((velocityModifyer + Speed), vel.y, vel.z);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            vel = new Vector3(-(velocityModifyer + Speed), vel.y, vel.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Speed = 5;
        }
        else
        {
            Speed = 2;
        }
        if (Input.GetKey(KeyCode.Space) && IsGrounded())
        {
            //_rb.AddForce(Vector3.up * velocity, ForceMode.Impulse);
            _as.Play();
            vel = new Vector3(vel.x, velocity, vel.z);
        }

        _rb.velocity = vel;
    }

    private bool IsGrounded()
    {
        Collider[] checking = Physics.OverlapSphere(groundChecker.position, GCradius, groundPlayer);

        
        return checking.Length > 0;       
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundChecker.position, GCradius);
    }
}
