using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform

    void Start()
    {
         player = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
    void Update()
    {
        if (player != null) // Make sure player reference is not null
        {
            // Get the direction from the enemy to the player
            Vector3 direction = player.position - transform.position;
            direction.y = 0f; // Ensure the enemy only rotates in the horizontal plane

            // Rotate the enemy to face the player
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}