using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelarator : MonoBehaviour
{
    public FirstPersonMovement movement;

    public float speedFactor = 2.5f;
    private void OnTriggerEnter(Collider other)
    {
        movement.runSpeed *= speedFactor;
    }
        

    private void OnTriggerExit(Collider other)
    {
        movement.runSpeed /= speedFactor;
    }
}
