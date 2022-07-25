using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dongu : MonoBehaviour
{
    public TextMeshProUGUI MyText;

    private void Start()
    {
        StartCoroutine(TextYazdir());
    }

    IEnumerator TextYazdir()
    {
        for (int i = 0; i <= 500; i++)
        {
            MyText.text = "Coin Earned: " + i.ToString();
            yield return new WaitForSeconds(0.001f);
        }
    }
}