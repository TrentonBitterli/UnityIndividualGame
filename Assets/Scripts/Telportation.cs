using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telportation : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player2");
    }

    public void TeleportPlayerUp()
    {
        player.transform.position = new Vector3(-96.3f, 15f, 21.9f);
    }

    public void TeleportPlayerDown()
    {
        player.transform.position = new Vector3(-129.7f, -27.9f, 16.7f);
    }

    public void TeleportMainMenu()
    {
        player.transform.position = new Vector3(0f, 0f, -13.64f);
    }
}
