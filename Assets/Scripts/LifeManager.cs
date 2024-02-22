using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public TextMeshProUGUI livesText;
    public int maxLives = 3;
    private int currentLives;

    void Start()
    {
        // Initialize the lives
        currentLives = maxLives;
        UpdateLivesText();
    }

    public void LoseLife()
    {
        if (currentLives > 0)
        {
            currentLives--;
            UpdateLivesText();
            Debug.Log("Updated Text!");
        }
        if(currentLives <= 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene("MainMenu");
        }
    }

    // Call this method to update the lives UI text
    void UpdateLivesText()
    {
        livesText.text = "Lives: " + currentLives.ToString();
    }
}
