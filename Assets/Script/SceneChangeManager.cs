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
        MainGame2,
        GameOver,
        BonusStage,
        Clear,
        Retry,
        End
    }

    private static string[] SceneName =
    {
          "Title",
          "MainGame",
           "MainGame2",
           "MainGame3",
           "BonusStage",
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
                if (Random.Range(0, 100) == 4)
                {
                    SelectStageStatus.StageNum = 4;
                    SceneManager.LoadScene(SceneName[SelectStageStatus.StageNum]);
                }
                else
                {
                    SelectStageStatus.StageNum = Random.Range((int)Scenes.MainGame, (int)Scenes.GameOver);
                    SceneManager.LoadScene(SceneName[SelectStageStatus.StageNum]);
                }
                 break;

            case Scenes.BonusStage:
                SelectStageStatus.StageNum = 4;
                SceneManager.LoadScene(SceneName[SelectStageStatus.StageNum]);
                break;

            case Scenes.GameOver:
                SceneManager.LoadScene(SceneName[(int)Scenes.GameOver]);
                break;

            case Scenes.Clear:
                SceneManager.LoadScene(SceneName[(int)Scenes.Clear]);
                break;

            case Scenes.Retry:
                SceneManager.LoadScene(SceneName[SelectStageStatus.StageNum]);
                break;

            case Scenes.End:
                Application.Quit();

                break;
            default:
                break;
        }
    }

}