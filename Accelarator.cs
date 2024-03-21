using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelarator : MonoBehaviour
{
    // Make a variable to store the movement script
    public FirstPersonMovement movement;
    // Make a new variable storing the more speed there is
    public float speedFactor = 2.5f;
    private void OnTriggerEnter(Collider other)
    {
        // Make the speed faster
        movement.runSpeed *= speedFactor;
    }
        

    private void OnTriggerExit(Collider other)
    {
        // Change the speed back to normal
        movement.runSpeed /= speedFactor;
    }
}
