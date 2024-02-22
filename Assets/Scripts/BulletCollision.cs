using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            // Destroy both bullets
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}