using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearButtonScript : MonoBehaviour
{

    public void RetryButton()
    {
        GameObject panel = GameObject.Find("FadeOutPanel");
        FadeOut fo = panel.GetComponent<FadeOut>();
        fo.begin(SceneChangeManager.SceneChange, SceneChangeManager.Scenes.MainGame);
    }

    public void HomeButton()
    {
        GameObject panel = GameObject.Find("FadeOutPanel");
        FadeOut fo = panel.GetComponent<FadeOut>();
        fo.begin(SceneChangeManager.SceneChange, SceneChangeManager.Scenes.Title);
    }
}
