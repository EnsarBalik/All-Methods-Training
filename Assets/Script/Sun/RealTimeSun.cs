using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealTimeSun : MonoBehaviour
{
    public Transform test;
    float speed;

    public float x;
    public float y;
    public float z;

    public float currentTime;
    public float dayLenghtMinutes;

    private float rotationSpeed;
    private float midday;
    private float translateTime;

    private void Start()
    {
        speed = 360 / dayLenghtMinutes / 60;
        midday = dayLenghtMinutes * 60 / 2;
    }

    void Update()
    {
        //transform.LookAt(test);
        //transform.RotateAround(test.position, new Vector3(x, y, z), speed * Time.deltaTime);

        currentTime += 1 * Time.deltaTime;

        transform.Rotate(new Vector3(1, 0, 0) * (speed * Time.deltaTime));

        float t = translateTime * 24f;

        float hours = Mathf.Floor(t);

        Debug.Log(hours);
    }
}