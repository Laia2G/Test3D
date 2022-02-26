using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowController : MonoBehaviour
{
    public Transform emptyCat;
    //public Transform[] emptyCat;
    //bool colision;
    public float velocity;

    private void takeCats()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        EmptyCats _hollowCat = other.GetComponent<EmptyCats>();
        if (_hollowCat)
        {
            emptyCat = _hollowCat.AddCat(this);
        }

    }

    /*public Transform emptyCat;
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
    }*/

    private void Update()
    {
        if (emptyCat)
        {
            //gameObject.transform.position = emptyCat.position;

            transform.localPosition = Vector3.Lerp(transform.localPosition, emptyCat.position, velocity * Time.deltaTime);
        }
    }
}
