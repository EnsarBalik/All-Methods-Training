using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealTimeSun : MonoBehaviour
{
    public Transform test;

    void Update()
    {
        transform.LookAt(test);
    }
}