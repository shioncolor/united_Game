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
        MainGame3,
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
          "GameOver",
          "BonusStage",
          "Clear"
    };

    private static bool nowBonus = false;

    public static void SceneChange(Scenes scene)
    {
        Debug.Log("Begin SC: " + SceneName[SelectStageStatus.StageNum]);

        switch (scene)
        {
            case Scenes.Title:
                nowBonus = false;
                SceneManager.LoadScene(SceneName[(int)Scenes.Title]);
                break;

            case Scenes.MainGame:
                nowBonus = false;
                if (Random.Range(0, 100) == 4)
                {
                    // Bonus stage!!
                    nowBonus = true;
                    SelectStageStatus.StageNum = (int)Scenes.BonusStage;
                    SceneManager.LoadScene(SceneName[(int)Scenes.BonusStage]);
                }
                else
                {
                    SelectStageStatus.StageNum = Random.Range((int)Scenes.MainGame, (int)Scenes.GameOver);
                    SceneManager.LoadScene(SceneName[SelectStageStatus.StageNum]);
                }
                 break;

            case Scenes.BonusStage:
                nowBonus = true;
                SelectStageStatus.StageNum = (int)Scenes.BonusStage;
                SceneManager.LoadScene(SceneName[(int)Scenes.BonusStage]);
                break;

            case Scenes.GameOver:
                Debug.Log(nowBonus);
                SceneManager.LoadScene(SceneName[(int)Scenes.GameOver]);
                if (nowBonus)
                {
                    SceneManager.sceneLoaded += (Scene now, LoadSceneMode mode) =>
                    {
                        if (now.name == "GameOver")
                        {
                            GameObject.Find("BackGround/BonusImage").SetActive(true);
                            GameObject.Find("BackGround/Image").SetActive(false);
                        }
                    };
                }
                nowBonus = false;
                break;

            case Scenes.Clear:
                nowBonus = false;
                SceneManager.LoadScene(SceneName[(int)Scenes.Clear]);
                SceneManager.sceneLoaded += (Scene now, LoadSceneMode mode) =>
                {
                    GameObject.Find("ScoreImage/Text").GetComponent<Text>().text = (int)MainGameManager.ScoreTime + "秒!";
                };
                break;

            case Scenes.Retry:
                SceneManager.LoadScene(SceneName[SelectStageStatus.StageNum]);
                break;

            case Scenes.End:
                Application.Quit();

                break;
            default:
                nowBonus = false;
                break;
        }
        Debug.Log("Ending SC: " + SceneName[SelectStageStatus.StageNum]);
    }

}