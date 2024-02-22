using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1TargetController : MonoBehaviour
{
    public Level1TargetManager targetManager;
    // Start is called before the first frame update
    void Start()
    {
        targetManager = GameObject.Find("Score Manager").GetComponent<Level1TargetManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            targetManager.GetComponent<Level1TargetManager>().CheckLevel1Targets();
            Destroy(gameObject);
        }
    }
}
