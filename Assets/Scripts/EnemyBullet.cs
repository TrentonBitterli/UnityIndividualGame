using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
         if (collision.gameObject.tag == "MainCamera")
         {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage();
            Debug.Log(gameObject);
            Destroy(gameObject);
         }
    }
}
