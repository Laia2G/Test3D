using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyCats : MonoBehaviour
{
    [System.Serializable]
    public struct emptyCat
    {
        public Transform emptyCatsPoint;
        public FollowController cat;
    }
    public AudioSource _as;
    [SerializeField]
    public emptyCat[] positions;
    public Transform AddCat(FollowController catHollow)
    {
        _as.Play();
        for (int i = 0; i < positions.Length; i++)
        {
            if (!positions[i].cat)
            {                
                positions[i].cat = catHollow;
                return positions[i].emptyCatsPoint;
            }
        }
        return null;
    }

    
}
