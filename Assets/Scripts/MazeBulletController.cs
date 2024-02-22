using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeBulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.tag == "Enemy")
    {
       collision.gameObject.GetComponent<MazeEnemyStats>().TakeDamage(1);
       Destroy(gameObject);
}
}
}
