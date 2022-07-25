using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpismalar : MonoBehaviour
{
    public Material Red;

    //*************ONTRIGGER*************

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Green")
        {
            Debug.Log("i�inden ge�ti");
            other.gameObject.GetComponent<MeshRenderer>().material = Red;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Green")
            Debug.Log("i�inde");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Green")
            Debug.Log("i�inden ��kt�");
    }

}