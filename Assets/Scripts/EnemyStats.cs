using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
     private GameObject sm;
     
    private int EnemyHealth1 = 2;

    private int EnemyMaxHealth = 2;

private void Start()
{
    EnemyHealth1 = EnemyMaxHealth;
    sm = GameObject.Find("EnemySpawner");
    
}
    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth1 <= 0)
        {
            Died();
        }
    }

    public void TakeDamage1(int damage)
    {
        EnemyHealth1 -= damage;
    }

    private void Died()
    {
         // try to spawn a new enemy
            sm.GetComponent<SpawnManager>().SpawnNewEnemy();
        Destroy(gameObject);
    }
}
