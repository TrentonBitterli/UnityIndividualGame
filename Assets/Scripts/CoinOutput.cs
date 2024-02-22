using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CoinOutput : MonoBehaviour
{
    ScoreManager scoreManager;
    public int coinCount = 0;

    public void Update()
    {
        coinCount = GameObject.Find("Score Manager").GetComponent<ScoreManager>().score;
    }
    public void SaveCoinCount()
    {
        string filePath = Application.persistentDataPath + "/"
            + System.DateTime.UtcNow.ToLocalTime().ToString("M-d-yy-HH-mm") + "CoinAmount.txt";
        try
        {
            File.WriteAllText(filePath, "Coins collected: " + coinCount.ToString());
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error saving coin count: " + e.Message);
        }
    }
}
