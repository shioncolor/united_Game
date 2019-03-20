using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager
{

    public enum Scenes
    {
        Title = 0,
        MainGame,
        End
    }

    private static string[] SceneName =
    {
          "Title",
          "MainGame"
     };

    public static void SceneChange(Scenes scene)
    {

        switch (scene)
        {
            case Scenes.Title:
                SceneManager.LoadScene(SceneName[(int)Scenes.Title]);
                break;
            case Scenes.MainGame:
                SceneManager.LoadScene(SceneName[(int)Scenes.MainGame]);
                break;
            case Scenes.End:
                Application.Quit();
                break;
            default:
                break;
        }
    }
}