using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TargetManager : MonoBehaviour
{
    public Stopwatch stopWatch;
    public int targets = 36;
    public TargetController targetController;
    public GameObject player;
    public TextMeshProUGUI targetsDestroyed;

    
    // Start is called before the first frame update
    void Start()
    {
        UpdateTargetText();
        player = GameObject.Find("Player");
        stopWatch = GameObject.Find("StopWatch").GetComponent<Stopwatch>();
    }

    public void CheckTargets()
    {
        --targets;
        UpdateTargetText();
        if(targets == 24)
        {
            player.transform.position = new Vector3(0.44f,109.72f,2.09f);
            Debug.Log("First 12 targets destroyed");
        }
        if(targets == 12)
        {
            player.transform.position = new Vector3(0.8f,196f,1f);
            Debug.Log("Second 12 targets destroyed"); 
        }
        if(targets == 0)
        {
            player.transform.position = new Vector3(0.8f, 352f, 1f);
            stopWatch.StopStopwatch();
            // SceneManager.LoadScene("MainMenu");
            Debug.Log("You shot all the targets!");
        }
    }

    public void UpdateTargetText()
    {
        targetsDestroyed.text = "Targets Remaining: " + targets.ToString();
    }
}
