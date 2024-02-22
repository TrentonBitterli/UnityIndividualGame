using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1; // Adjust the score value as needed

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Adjust the tag based on your player object
        {
            CollectCoin();
        }
    }

    void CollectCoin()
    {
        // Add score
        ScoreManager.Instance.AddScore(coinValue);

        // Destroy the coin object
        Destroy(gameObject);
    }
}
