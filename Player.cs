using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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
}
