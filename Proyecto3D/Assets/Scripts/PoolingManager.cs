
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]

public class PooledItems
{
    public string Name;
    public GameObject objectToPool;
    public int amount;
}
public class PoolingManager : MonoBehaviour
{
    //public static PoolingManager _instance;
    //public static PoolingManager Instance => _instance;

    //public List<GameObject> pooledObjects;
    //public GameObject objectToPool;
    //public int amount;

    private static PoolingManager _instance;

    public static PoolingManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<PoolingManager>();
            }
            return _instance;
        }
    }

    [SerializeField]
    private List<PooledItems> pooledLists = new List<PooledItems>();

    [SerializeField]
    private Dictionary<string, List<GameObject>> _items = new Dictionary<string, List<GameObject>>();

    private void Awake()
    {
        for (int i = 0; i < pooledLists.Count; i++)
        {
            PooledItems l = pooledLists[i];
            _items.Add(l.Name, new List<GameObject>());

            for (int j = 0; j < l.amount; j++)
            {
                GameObject tmp;
                tmp = Instantiate(l.objectToPool);
                tmp.SetActive(false);
                _items[l.Name].Add(tmp);
            }
        }
    }

    public GameObject GetPooledObject(string name)
    {
        List<GameObject> tmp = _items[name];
        for (int i = 0; i < tmp.Count; i++)
        {
            if (!tmp[i].activeInHierarchy)
            {
                return tmp[i];
            }
        }
        return null;
    }

    /*void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        
        for(int i = 0; i < amount; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }

    public GameObject GetPooledObject()
    {
        for(int i = 0; i < amount; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }*/
}

/*
 [Serializable]
public class PooledItems
{
    public string Name;
    public GameObject objectToPool;
    public int amount;
}
private static PoolingManager _instance;
public static PoolingManager Instance
{
    get
    {
        if()
        {
              _instance = FindObjectOfType<PoolingManager>();          
        }
        return _instance
    }
}
 */
