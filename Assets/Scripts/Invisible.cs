using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{
    public AudioSource coinDeposit;
    public void Start()
    {
        coinDeposit = GameObject.Find("CoinSound").GetComponent<AudioSource>();
    }

    public void Hide()
    {
        coinDeposit.Play();
        gameObject.SetActive(false);
    }
}
