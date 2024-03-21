using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    
    // Make a variable that controlls the data of the other script
    public Jump jump;
    // Make a variable that will store the jumpStrength in the future
    public float jumpOld;
    public void OnCollisionEnter(Collision collision)
    {
        // Make the "jumpOld" variable store jumpStrength before the change
        jumpOld = jump.jumpStrength;
        // Change the jumpStrength variable to 10 to increase jump
        jump.jumpStrength = 10;
        
}

    private void OnCollisionExit(Collision collision)
    {
        // Change it back to default
        jump.jumpStrength = jumpOld;
    }
}
