using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 24f;

    [SerializeField] private Rigidbody rb;

    private void FixedUpdate()
    {
        rb.velocity = Vector3.right * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Untagged"))
        {
            gameObject.SetActive(false);
        }
    }

    private void CloseObject()
    {
        gameObject.SetActive(false);
    }
}