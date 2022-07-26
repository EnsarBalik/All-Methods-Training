using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour
{
    public Transform VectorBack;
    public Transform VectorForward;

    public void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.z = Mathf.Clamp(viewPos.z, VectorBack.transform.position.z, VectorForward.transform.position.z);
        transform.position = viewPos;
    }
}
