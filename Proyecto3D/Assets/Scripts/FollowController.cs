using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowController : MonoBehaviour
{
    public Transform emptyCat;
    public float velocity;

    private void OnTriggerEnter(Collider other)
    {
        EmptyCats _hollowCat = other.GetComponent<EmptyCats>();
        if (_hollowCat)
        {
            emptyCat = _hollowCat.AddCat(this);
        }

    }
    private void Update()
    {
        if (emptyCat)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, emptyCat.position, velocity * Time.deltaTime);
        }
    }
}
