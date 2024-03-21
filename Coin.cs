ing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Get the "Player" script
        Player player = other.GetComponent<Player>();

        // The number of coins is changed
        player.CollectCoins();
        
        // Destroy the gameObject
        Destroy(gameObject);
    }
}
