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
    
    // Start is called before the first frame update
    void Start()
    {
      _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
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
            vel = new Vector3(vel.x, velocity, vel.z);
            //Speed = 2;
        }

        _rb.velocity = vel;
    }

    private bool IsGrounded()
    {
        Collider[] checking = Physics.OverlapSphere(groundChecker.position, GCradius, groundPlayer);

        
        return checking.Length > 0;
        
        
        //return Physics.CheckCapsule(colliderSphere.bounds.center, new Vector3(colliderSphere.bounds.center.x, colliderSphere.bounds.min.y, colliderSphere.bounds.center.z), colliderSphere.radius * 0.9f, groundPlayer);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundChecker.position, GCradius);
    }
}
