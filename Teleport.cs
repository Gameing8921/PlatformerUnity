using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;

    void OnTriggerEnter(Collider collision)
    {
        collision.GetComponent<Transform>().position = teleportPoint.position;  
    }
}
    
