using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling instance;

    private List<GameObject> objects = new List<GameObject>();
    private int amountToPool = 20;

    [SerializeField] private GameObject bullet;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(bullet);
            obj.SetActive(false);
            objects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            if (!objects[i].activeInHierarchy)
            {
                return objects[i];
            }
        }

        return null;
    }
}