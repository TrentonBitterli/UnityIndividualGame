using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
   [SerializeField] private float timer = 2;
   private float bulletTime;

   public Transform spawnPoint;

   public float bulletSpeed;

   public GameObject enemyBullet;

   void Update()
   {
    ShootAtPlayer();
   }

   void ShootAtPlayer()
   {
    bulletTime -= Time.deltaTime;

    if (bulletTime > 0) return;

    bulletTime = timer;

    GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
    Destroy(bulletObj, 3f);
   }
}
