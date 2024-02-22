using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager Instance;

    public TextMeshProUGUI currentScore;

    public int score = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();

    }

    void UpdateScoreText()
    {
        // Update the UI text element with the current score
        if (currentScore != null)
        {
            currentScore.text = "Coins: " + score.ToString();
        }
    }
}
