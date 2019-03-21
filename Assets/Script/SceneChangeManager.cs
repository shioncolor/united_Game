using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChangeManager
{

    public enum Scenes
    {
        Title = 0,
        MainGame,
        GameOver,
        Clear,

        End
    }

    private static string[] SceneName =
    {
          "Title",
          "MainGame",
          "GameOver",
          "Clear"
    };

    public static void SceneChange(Scenes scene)
    {

        switch (scene)
        {
            case Scenes.Title:
                SceneManager.LoadScene(SceneName[(int)Scenes.Title]);
                break;

            case Scenes.MainGame:
                int random = Random.Range((int)Scenes.MainGame, (int)Scenes.GameOver);
                SceneManager.LoadScene(SceneName[random]);
                break;

            case Scenes.GameOver:
                SceneManager.LoadScene(SceneName[(int)Scenes.GameOver]);
                break;

            case Scenes.Clear:
                SceneManager.LoadScene(SceneName[(int)Scenes.Clear]);
                break;

            case Scenes.End:
                Application.Quit();
                break;
            default:
                break;
        }
    }

}