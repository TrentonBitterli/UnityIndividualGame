using UnityEngine;

public class BulletFollowPlayer : MonoBehaviour
{
    public float speed = 50f; // Speed of the bullet
    private Transform player; // Reference to the player's transform
    private Vector3 target; // The position the bullet will move towards

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera").transform; // Find the player GameObject by tag
        target = player.position; // Set the target position to the player's position
    }

    void Update()
    {
         // Calculate the direction towards the target (player)
        Vector3 direction = target - transform.position;

        // Move the bullet towards the target
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}