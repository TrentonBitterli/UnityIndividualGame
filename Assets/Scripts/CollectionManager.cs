using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectionManager : MonoBehaviour
{
    public ScoreManager scoreManager; //Reference to Score Script
    public SpawnManager spawnManager; //Reference to Spawn Script
    public GameObject player;
    public RunAndGunStopwatch stopWatch;

    void Start()
    {
        player = GameObject.Find("Player2");
        stopWatch = GameObject.Find("StopWatch").GetComponent<RunAndGunStopwatch>();
    }
    // Update is called once per frame
    void Update()
    {
         if(scoreManager.score == 6 && spawnManager.respawns == spawnManager.maxRespawns)
         {
             player.transform.position = new Vector3(211.29f, -4.09f, 5.22f);
            stopWatch.StopStopwatch();
            Debug.Log("You collected all Coins and shot all Enemies!");
         }
    }
}
