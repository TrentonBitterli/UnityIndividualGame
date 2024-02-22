using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeEnemyStats : MonoBehaviour
{
    public int EnemyHealth = 5;
    private int EnemyMaxHealth = 5;
    // Start is called before the first frame update
    void Start()
    {
        EnemyHealth = EnemyMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth <= 0)
        {
            Died();
        }        
    }

    public void TakeDamage(int damage)
    {
        EnemyHealth -= damage;
        
        GameObject CanvasChild = transform.GetChild(0).gameObject;
        GameObject HealthBarChild = CanvasChild.transform.GetChild(0).gameObject;
        HealthBarChild.GetComponent<EnemyHealthBar>().ChangeHealth(EnemyHealth);
        GetCurrentHealth();
    }

    private void Died()
    {
        Destroy(gameObject);
    }

    public int GetCurrentHealth()
    {
        return EnemyHealth;
    }
}
