using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastAttempt : MonoBehaviour
{
    public Transform player;
    public float shootingRange = 30f;
    public float shootInterval = 1f;
    public GameObject enemyBullet;

    public Transform spawnPoint;

    private float lastShootTime;

    void Update()
    {
        Vector3 directionToPlayer = player.position - transform.position;
        RaycastHit hit;

        // Check if player is within shooting range
        if (Physics.Raycast(transform.position, directionToPlayer, out hit, shootingRange))
        {
            // Check if the object hit by the raycast is the player
            if (hit.collider.CompareTag("MainCamera"))
            {
                // Check if enough time has passed since last shoot
                if (Time.time - lastShootTime >= shootInterval)
                {
                    Shoot();
                    lastShootTime = Time.time;
                }
            }
        }
    }

    void Shoot()
    {
            GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
            Destroy(bulletObj, 3f);
        }
}
