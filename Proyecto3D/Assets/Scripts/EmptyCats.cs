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
    //bool follower;
    [SerializeField]
    public emptyCat[] positions;
    // Start is called before the first frame update
    public Transform AddCat(FollowController catHollow)
    {
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

    public void EndEmpty()
    {

    }
}
