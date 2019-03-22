using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearLoaded : MonoBehaviour {

    public static void ClearSceneLoaded(Scene i_loadedScene, LoadSceneMode i_mode)
    {
        GameObject.Find("ScoreImage/Text").GetComponent<Text>().text = SceneChangeManager.time.ToString("F1") + "秒!";
    }
}
