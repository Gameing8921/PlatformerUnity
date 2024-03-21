using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    private int coins;
    public AudioSource audioSource;
    public AudioClip collectCoins;
        // Call CollectCoins with the "Coins" script
    public void CollectCoins()
    {
        // variableName ++ means variableName = variableName + 1
        coins++;
        // PlayOneShot means play once
        audioSource.PlayOneShot(collectCoins);

        print("coins:" +  coins);
    }
        // Call TakeDamage later
    public void TakeDamage()
    {

    }
}
