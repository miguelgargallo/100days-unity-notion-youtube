using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchThisWallAndDestroyYourself : MonoBehaviour
{
    // OnCollisionEnter is called when this collider/rigidbody has begun
    // touching another rigidbody/collider.
    private void OnCollisionEnter(Collision collision)
    {
        // Destroy the GameObject that collides with this GameObject.
        Destroy(collision.gameObject);
    }

    // OnTriggerEnter is called when the Collider other enters the trigger.
    private void OnTriggerEnter(Collider other)
    {
        // Destroy the GameObject that enters this trigger.
        Destroy(other.gameObject);
        Debug.Log("Game Over!");
    }

}
 