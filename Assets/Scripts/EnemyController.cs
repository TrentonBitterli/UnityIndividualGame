using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private GameObject sm;
    public bool Dead = false;
    
    private Transform player;

    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        sm = GameObject.Find("EnemySpawner");
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Destroy the bullet
            Destroy(collision.gameObject);

            // try to spawn a new enemy
            sm.GetComponent<SpawnManager>().SpawnNewEnemy();

            // Destroy the enemy
            Destroy(gameObject);
        }
    }
}
