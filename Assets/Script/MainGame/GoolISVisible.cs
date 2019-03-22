using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GoolISVisible : MonoBehaviour
{

    Vector3 goolPos;

    [SerializeField]
    GameObject FadePanel;

    [SerializeField]
    GameObject Player;
    [SerializeField]
    GameObject Player2;

    [SerializeField]
    float time = 2.0f;

    private static string[] Name =
    {
          "Ink",
          "light",
           "Itigo",
           "Sugar",
           "Key",
          "Leaf",
          "Chara"
    };

    private void Start()
    {

    }
    void OnBecameVisible()
    {
        StopClass.Stop = true;

        StartCoroutine("Visible");
        
    }

    private IEnumerator Visible()
    {

        yield return new WaitForSeconds(2f);

        //ゲームオーバー
        FadeIO fo = FadePanel.GetComponent<FadeIO>();
        fo.doFadeOut(SceneChangeManager.SceneChange, SceneChangeManager.Scenes.Clear);
    }
}
