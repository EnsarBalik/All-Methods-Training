using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicControll : MonoBehaviour
{
    public float moveSpeed;

    private int _attackDamage = 1;

    CharacterController ch;

    private void Start()
    {
        ch = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        ch.Move(new Vector3(x, 0, z));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<IDamageable<int>>() != null)
        {
            other.gameObject.GetComponent<IDamageable<int>>().TakeDamage(_attackDamage);
        }
    }
}