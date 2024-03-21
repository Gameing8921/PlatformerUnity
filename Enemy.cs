using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemy Movement speed 
    public float speed;

    // The target is enemy moving towards
    public Transform target;

    // Damagepoint from an attack by the player enemy
    private int playerDamage = 2;

    // Update is called once per frame
    void Update()
    {
        // Change NPC pos to a new one every frame
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Look at the player
        transform.LookAt(target.position);

     
    }
    private void OnTriggerStay(Collider other)
    {
        // Get the "Player" script
        Player player = other.GetComponent<Player>();

        // Use the "Player" script to take damage from the player
        player.TakeDamage(playerDamage);
    }
}


