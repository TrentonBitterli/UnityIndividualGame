using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadTargetScene(string GameplayLoop)
    {
        SceneManager.LoadScene(GameplayLoop);
    }

        public void LoadStartScene(string Start)
    {
        SceneManager.LoadScene(Start);
    }

    public void LoadShopScene(string Shop)
    {
        SceneManager.LoadScene(Shop);
    }
}
