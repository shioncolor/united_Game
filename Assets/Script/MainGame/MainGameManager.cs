using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Ready))]

public class MainGameManager : MonoBehaviour {


    [SerializeField]
    private GameObject[] Player;
    [SerializeField]
    private GameObject Enemy;
    [SerializeField]
    GameObject FadePanel;
    [SerializeField]
    GameObject ScoreTextObject;

    private float time;
    private int random;
    private Text ScoreText;
    // Use this for initialization
    void Start () {
        //経過時間テキストの取得
        ScoreText = ScoreTextObject.GetComponent<Text>();

        //playerの生成
        if (SelectStageStatus.StageNum != 4)
        {
            SelectStageStatus.PlayerNum = Random.Range(0, Player.Length);
            Instantiate(Player[SelectStageStatus.PlayerNum]);
        }
        var RedyGo = GetComponent<Ready>();
        RedyGo.RedyGo();
    }
	
	// Update is called once per frame
	void Update () {

        if (StopClass.Stop)
            return;

        time += Time.deltaTime;
        ScoreText.text = time.ToString("F1") + "秒!";

        if (EnemyAction.Trun && !PlayerStatus.Hide)
        {
            StartCoroutine("GameOver");
        }
        Debug.Log(time);
        if (time > 1.0f)
        {
            Debug.Log("Start Clear Coroutine");
            StartCoroutine("Clear");
        }
    }

    private IEnumerator GameOver()
    {
        Debug.Log("GameOver Coroutine now");
        StopClass.Stop = true;

        yield return new WaitForSeconds(1.0f);
        Animator anim = Enemy.GetComponent<Animator>();
        anim.SetTrigger("GameOver");

        yield return new WaitForSeconds(2f);

        //ゲームオーバー
        FadeIO fo = FadePanel.GetComponent<FadeIO>();
        fo.doFadeOut(SceneChangeManager.SceneChange, SceneChangeManager.Scenes.GameOver);
    }

    // ゴールした時にtimeを投げるやつのサンプル
    private IEnumerator Clear()
    {
        Debug.Log("Clear Coroutine now");
        StopClass.Stop = true;

        SceneChangeManager.time = time;

        yield return new WaitForSeconds(1f);

        //クリア
        FadeIO fo = FadePanel.GetComponent<FadeIO>();
        fo.doFadeOut(SceneChangeManager.SceneChange, SceneChangeManager.Scenes.Clear);
    }
}
