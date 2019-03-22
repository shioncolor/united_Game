using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusButton : MonoBehaviour {

    int count = 0;

    [SerializeField]
    GameObject panel;
    public void PushButton()
    {
        count++;
        if(count>=20)
        {
            FadeIO fo = panel.GetComponent<FadeIO>();
            fo.doFadeOut(SceneChangeManager.SceneChange, SceneChangeManager.Scenes.BonusStage);
        }
    }
}
