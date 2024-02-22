using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1TargetManager : MonoBehaviour
{
    public int Level1targets = 3;
    public Level1TargetController targetController;
    public GameObject secretCoin;
    public GameObject chest;

        void Start()
    {
        secretCoin.SetActive(false);
    }

    public void CheckLevel1Targets()
    {
        --Level1targets;
        if(Level1targets == 0)
        {
            secretCoin.SetActive(true);
            chest.SetActive(false);
            Debug.Log("All Targets Destroyed");
        }
    }
}
