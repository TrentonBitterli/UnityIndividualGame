using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public ScoreManager scoreManager; //Reference to Score Script
 public GameObject enemyPrefab; // Reference to your enemy prefab
    public GameObject bulletPrefab; // Reference to your bullet prefab
    public int maxRespawns = 10;    // Maximum number of respawns
    public float respawnDelay = 1f; // Delay between respawns in seconds
    private bool spawningEnemy = false;
    public TextMeshProUGUI enemies;
    public AudioSource enemyDie;

    public int enemiesLeft = 15;
    public int respawns = 0;
    private int score = 0;

    void Start()
    {
        enemyDie = GameObject.Find("EnemyDieSound").GetComponent<AudioSource>();
        UpdateEnemiesText();
        // Start spawning enemies
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        // Generate a random spawn position
        Vector3 spawnPosition = new Vector3(Random.Range(-65f, 100f), Random.Range(-25, -20f), Random.Range(-30f, 60f));

        // Instantiate the enemy at the random position
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    public void SpawnNewEnemy()
    {
        enemyDie.Play();
        enemiesLeft--;
        UpdateEnemiesText();
        respawns++;
        if (respawns < maxRespawns)
        {
            AddScore();
            if (!spawningEnemy)
            {
                spawningEnemy = true;
                StartCoroutine(SpawnPauseTimer());
            }
        }
    }

    IEnumerator SpawnPauseTimer()
    {
        yield return new WaitForSeconds(respawnDelay);
        SpawnEnemy();
        spawningEnemy = false;
    }

    public void AddScore()
    {
        score++;
        Debug.Log("Enemy Hit!");
        Debug.Log(score);
    }

        private void LoadNewScene()
    {
        SceneManager.LoadScene("End");
    }

        void UpdateEnemiesText()
    {
        enemies.text = "Enemies Remaining: " + enemiesLeft.ToString();
    }
}
