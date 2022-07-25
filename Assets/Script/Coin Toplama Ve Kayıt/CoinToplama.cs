using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinToplama : MonoBehaviour
{
    public int PlayerCoin;
    public TextMeshProUGUI CoinText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            PlayerCoin++;
            Destroy(other.gameObject);
            CoinText.text = "" + PlayerCoin;
        }
    }
}