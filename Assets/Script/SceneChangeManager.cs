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
        GameOver,

        End
    }

    private static string[] SceneName =
    {
          "Title",
          "MainGame",
          "GameOver"
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

            case Scenes.End:
                Application.Quit();
                break;
            default:
                break;
        }
    }

}