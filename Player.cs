using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    private int coins;
    public AudioSource audioSource;
    public AudioClip collectCoins;

    public void CollectCoins()
    {
        // variableName ++ means variableName = variableName + 1
        coins++;
        // PlayOneShot means play once
        audioSource.PlayOneShot(collectCoins);

        print("coins:" +  coins);
    }

    public void TakeDamage(int damagePoints)
    {
        // Take health from the taken damage (health -= damagePoints)
        health -= damagePoints;
        print(health);
    }
}
