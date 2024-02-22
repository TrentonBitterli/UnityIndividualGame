using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int maxLives = 3;
    private int currentLives;
        public TextMeshProUGUI livesText;

    private void Start()
    {
        currentLives = maxLives;
        UpdateLivesText();
    }

    private void OnCollisionEnter(Collider other)
    {
        if (other.CompareTag("EnemyBullet"))
        {
            Destroy(other);
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        currentLives--;
        UpdateLivesText();
        Debug.Log("Lost Life");

        if (currentLives <= 0)
        {
            SceneManager.LoadScene("MainMenu");
            Debug.Log("Dead");
        }
    }

    void UpdateLivesText()
    {
        livesText.text = "Lives: " + currentLives.ToString();
    }
}
