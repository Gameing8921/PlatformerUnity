using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Make a variable that controlls the data of the other script
    public Jump jump;
    private void OnCollisionEnter(Collision collision)
    {
        // Change the jumpStrength variable to 10 to increase jump
        jump.jumpStrength = 10;
    }

    private void OnCollisionExit(Collision collision)
    {
        // Change it back to default
        jump.jumpStrength = 2;
    }
}
