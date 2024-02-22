using UnityEngine;
using System.IO;

public class SaveLoad : MonoBehaviour
{

    public void BeginShutdown()
    {
        GetComponent<SaveData>().DataSaving();
        GetComponent<CoinOutput>().SaveCoinCount();
        SaveData();
    }

    private void SaveData()
    {
        Application.Quit();
    }
}
