using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    public Transform desPos;

    private GameObject _notListedObject;

    private void Start()
    {
        Shoot();
    }

    private void Shoot()
    {
        objects[0].gameObject.SetActive(true);
        objects[0].GetComponent<Rigidbody>().velocity = Vector3.right * 20;
        _notListedObject = objects[0];

        objects.RemoveAt(0);

        Invoke("GetToThePool", 2);
    }

    public void GetToThePool()
    {
        objects.Add(_notListedObject);
        _notListedObject.transform.position = desPos.position;
        _notListedObject.SetActive(false);

        Shoot();
    }

    public void ShootWithVelocity(Vector3 velocity)
    {
        objects[0].gameObject.SetActive(true);
        objects[0].GetComponent<Rigidbody>().velocity = velocity;
        _notListedObject = objects[0];

        objects.RemoveAt(0);

        Invoke("GetToThePool", 2);
    }
}