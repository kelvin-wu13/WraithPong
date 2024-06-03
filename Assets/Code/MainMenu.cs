using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame1()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Quitgame()
    {
        Application.Quit();
    }

    public void PlayGame2()
    {
        SceneManager.LoadSceneAsync(2);
    }
}

