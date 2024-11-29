using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int numberOfCoins;
    public TextMeshProUGUI textCoin;
    // Start is called before the first frame update
    private void Update()
    {
        textCoin.text = numberOfCoins.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            numberOfCoins++;
            Destroy(gameObject);
            Debug.Log("Pièce récupérée! Nouveau score : " + numberOfCoins);

        }
    }
}
