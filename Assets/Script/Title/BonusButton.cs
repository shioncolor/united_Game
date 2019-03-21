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
            FadeOut fo = panel.GetComponent<FadeOut>();
            fo.begin(SceneChangeManager.SceneChange, SceneChangeManager.Scenes.BonusStage);
        }
    }
}
