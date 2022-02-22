using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowController : MonoBehaviour
{
    public Transform emptyCat;
    int random;
    bool colision;
    public float velocity;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            random = Random.Range(0,2);
            colision = true;
        } 
    }

    private void Update()
    {
        if (colision)
        {
            //gameObject.transform.position = emptyCat.position;

            transform.localPosition = Vector3.Lerp(transform.localPosition, emptyCat.position, (velocity + random) * Time.deltaTime);
        }
    }
}
