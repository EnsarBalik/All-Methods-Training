using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicControll : MonoBehaviour
{
    public float moveSpeed;
    public Transform bulletPos;

    private int _attackDamage = 1;

    CharacterController ch;

    public List<Health> testList;

    private void Start()
    {
        ch = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        ch.Move(new Vector3(x, 0, z));

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<IDamageable<int>>() != null)
        {
            other.gameObject.GetComponent<IDamageable<int>>().TakeDamage(_attackDamage);
        }
    }

    private void Shoot()
    {
        GameObject bullet = ObjectPooling.instance.GetPooledObject();

        if(bullet != null)
        {
            bullet.transform.position = bulletPos.position;
            bullet.SetActive(true);
        }
    }
}