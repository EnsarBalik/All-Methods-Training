using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour
{
    public Transform target;
    public Transform mainObject;

    public float h = 25;
    public float gravity = -15;

    private void Update()
    {
        drawPath();
    }

    public LaunchData CalculateLaunchData()
    {
        float displacementY = target.position.y - mainObject.transform.position.y;
        Vector3 displacementXZ = new Vector3(target.position.x - mainObject.position.x, 0,
            target.position.z - mainObject.position.z);
        float time = Mathf.Sqrt(-2 * h / gravity) + Mathf.Sqrt(2 * (displacementY - h) / gravity);
        Vector3 velocityY = Vector3.up * Mathf.Sqrt(-2 * gravity * h);
        Vector3 velocityXZ =
            displacementXZ / time;

        return new LaunchData(velocityXZ + velocityY * -Mathf.Sign(gravity), time);
    }

    public void drawPath()
    {
        LaunchData launchData = CalculateLaunchData();
        Vector3 previousDrawPoint = mainObject.position;

        int resolation = 30;
        for (int i = 1; i <= resolation; i++)
        {
            float simulationTime = i / (float)resolation * launchData.timeToTarget;
            Vector3 displacement = launchData.initialVelocity * simulationTime +
                                   Vector3.up * gravity * simulationTime * simulationTime / 2f;
            Vector3 drawPoint = mainObject.position + displacement;
            Debug.DrawLine(previousDrawPoint, drawPoint, Color.red);
            previousDrawPoint = drawPoint;
        }
    }

    public struct LaunchData
    {
        public readonly Vector3 initialVelocity;
        public readonly float timeToTarget;

        public LaunchData(Vector3 initialVelocity, float timeToTarget)
        {
            this.initialVelocity = initialVelocity;
            this.timeToTarget = timeToTarget;
        }
    }
}