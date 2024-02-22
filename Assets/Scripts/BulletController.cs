using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            //Adds a point of damage to the Enemy GameObject
            collision.gameObject.GetComponent<EnemyStats>().TakeDamage1(1);
            Destroy(gameObject);
        }
    }
}
