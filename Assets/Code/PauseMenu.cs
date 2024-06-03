using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pm;
    public void Pause()
    {
        pm.SetActive(true);
        Time.timeScale = 0;
    }

    public void Home()
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;
    }

    public void Resume()
    {
        pm.SetActive(false);
        Time.timeScale = 1;
    }
}
