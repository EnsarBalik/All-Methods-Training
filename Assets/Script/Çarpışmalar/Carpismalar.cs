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
            Debug.Log("içinden geçti");
            other.gameObject.GetComponent<MeshRenderer>().material = Red;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Green")
            Debug.Log("içinde");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Green")
            Debug.Log("içinden çýktý");
    }

}