using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public GameObject warningMessage;
    public ScoreManager scoreManager;
    public int exitLimit = 5;
    public MazeStopwatch stopWatch;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        warningMessage.SetActive(false);
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        stopWatch = GameObject.Find("StopWatch").GetComponent<MazeStopwatch>();
        Debug.Log(scoreManager.score);
    }

    // // Update is called once per frame
    // void Update()
    // {

    // }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player") // Adjust the tag based on your player object
        {
            CheckCoinStatus();
        }
    }

    public void CheckCoinStatus()
    {
        if (scoreManager.score >= exitLimit)
        {
            scoreManager.score = 5;
            player.transform.position = new Vector3(0.93f, 354.66f, 1.77f);
            stopWatch.StopStopwatch();
        }
        else
        {
            warningMessage.SetActive(true);
            Invoke("TurnOff", 2);
        }
    }

    public void TurnOff()
    {
        warningMessage.SetActive(false);
    }
}
