using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public TargetManager targetManager;
    private void Start()
    {
        targetManager = GameObject.Find("TargetTracker").GetComponent<TargetManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            targetManager.GetComponent<TargetManager>().CheckTargets();
            Destroy(gameObject);
        }
    }
}
