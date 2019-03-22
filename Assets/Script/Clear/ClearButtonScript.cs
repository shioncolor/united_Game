using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearButtonScript : MonoBehaviour
{

    public void RetryButton()
    {
        GameObject panel = GameObject.Find("FadePanel");
        FadeIO fo = panel.GetComponent<FadeIO>();
        fo.doFadeOut(SceneChangeManager.SceneChange, SceneChangeManager.Scenes.Retry);
    }

    public void HomeButton()
    {
        GameObject panel = GameObject.Find("FadePanel");
        FadeIO fo = panel.GetComponent<FadeIO>();
        fo.doFadeOut(SceneChangeManager.SceneChange, SceneChangeManager.Scenes.Title);
    }
}
