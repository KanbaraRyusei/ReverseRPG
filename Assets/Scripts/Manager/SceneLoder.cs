using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoder
{
    public static string BeforeSceneName => _beforeSceneName;

    private static string _beforeSceneName;

    public static void LoadScene(string name)
    {
        _beforeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(name);
    }

    public static void LoadBeforeScene()
    {
        SceneManager.LoadScene(_beforeSceneName);
    }
}
