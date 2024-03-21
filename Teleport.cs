using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Get where to teleport to
    public Transform teleportPoint;

    void OnTriggerEnter(Collider collision)
    {
        // Teleport to the set position
        collision.GetComponent<Transform>().position = teleportPoint.position;  
    }
}
    
