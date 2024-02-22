using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAmbience : MonoBehaviour
{
    public AudioSource ambience;
    // Start is called before the first frame update
    void Start()
    {
        ambience.Play();
    }
}
