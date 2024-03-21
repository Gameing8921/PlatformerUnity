using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEditor.VersionControl;
using System;

public class Player : MonoBehaviour
{
    // Make all required variables
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

        // Print coins
        print("coins:" +  coins);
    }

    public void TakeDamage(int damagePoints)
    {
        // Take health from the taken damage (health -= damagePoints)
        health -= damagePoints;
        print("health:" + health);

        // Check if health is lost
        if (health <= 0) 
        {
            // Reset the scene
            EditorSceneManager.LoadScene("Level_1");
        }
    }
}



