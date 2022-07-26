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
        if (other.gameObject.CompareTag("Wall"))
        {
            gameObject.SetActive(false);
        }

        if (other.gameObject.GetComponent<IDamageable<int>>() != null)
        {
            other.gameObject.GetComponent<IDamageable<int>>().TakeDamage(1);
        }
    }
}