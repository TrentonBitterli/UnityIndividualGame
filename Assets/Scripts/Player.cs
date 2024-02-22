using UnityEngine;

public class Player : MonoBehaviour
{
    LifeManager lifeManager;
    public int maxLives = 3;  // Set your desired number of lives here
    private int currentLives;

    private void Start()
    {
        lifeManager = FindObjectOfType<LifeManager>();
        currentLives = maxLives;
    }

    public void TakeDamage(int damage)
    {
        currentLives -= damage;
        Debug.Log("Been Hit");
        lifeManager.LoseLife();

        // Check if the player is out of lives
        if (currentLives <= 0)
        {
            // Implement game over logic here
            Debug.Log("Game Over!");
        }
    }
}
