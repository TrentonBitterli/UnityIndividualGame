using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    public int maxLives = 3;
    private int currentLives;

    private void Start()
    {
        currentLives = maxLives;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyBullet"))
        {
            Destroy(other);
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        currentLives--;
        Debug.Log("Lost Health");
        if (currentLives <= 0)
        {
            // GameOver();
            Debug.Log("Dead");
        }
    }

    // private void GameOver()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    // }
}
