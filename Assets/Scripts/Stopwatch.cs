using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Stopwatch : MonoBehaviour
{
    bool stopwatchActive = false;
    public float currentTime;
    public TextMeshProUGUI currentTimeText;

    void Awake()
    {
        currentTime = 0;
    }
    void Start()
    {
        StartStopwatch();
    }

    public void Update()
    {
        if (stopwatchActive == true) {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = "You completed Target Practice in " + time.Minutes.ToString() + ":" + time.Seconds.ToString() + " seconds";
    }

    public void StartStopwatch() {
        stopwatchActive = true;
    }

    public void StopStopwatch() {
        stopwatchActive = false;
    }
}
