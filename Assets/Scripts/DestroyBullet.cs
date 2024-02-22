using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public float delay = 3f;

    void Start()
    {
        Invoke("RemoveBullet", delay);
    }

    void RemoveBullet()
    {
        Destroy(gameObject);
    }
}
