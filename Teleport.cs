using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Check if the collided object is tagged as "Player"
            PositionStore posPlayer = collision.gameObject.GetComponent<PositionStore>();
            if (posPlayer != null)
            {
                // Update the positionLoad of the PositionStore
                posPlayer.positionLoad.position = teleportPoint.position;
            }
            else
            {
                Debug.LogError("PositionStore component not found on the player object.");
            }
        }
    }
}
