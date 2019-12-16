using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void SceneLoader(string SceneString)
    {
        SceneManager.LoadScene(SceneString);
    }

    public void ExitApp()
    {
        Application.Quit();
    }

}
