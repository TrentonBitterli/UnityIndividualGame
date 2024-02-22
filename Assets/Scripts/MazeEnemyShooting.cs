using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeEnemyShooting : MonoBehaviour
{
    public Transform player;  // Reference to the player's transform
    public float shootingRange = 10f;  // The range at which the enemy will start shooting
    public float shootingDelay = 1f;  // The delay between shots

    public float enemySpeed;

    public Transform spawnPoint;
    public GameObject enemyBullet;
    private float lastShotTime;  // Time of the last shot

    void Update()
    {
        // Check if the player is in shooting range
        if (Vector3.Distance(transform.position, player.position) <= shootingRange)
        {
            // Check if enough time has passed since the last shot
            if (Time.time - lastShotTime >= shootingDelay)
            {
                // Shoot at the player (you should implement your own shooting logic here)
                Shoot();

                // Update the last shot time
                lastShotTime = Time.time;
            }
        }
    }

    void Shoot()
    {
        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);
        Destroy(bulletObj, 2f);
        Debug.Log("Enemy shoots at the player!");
        // You can add code to instantiate bullets or perform other shooting actions
    }
}
