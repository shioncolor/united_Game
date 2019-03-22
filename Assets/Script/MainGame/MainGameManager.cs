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

    private float time;
    private int random;
    // Use this for initialization
    void Start () {

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

        if (EnemyAction.Trun && !PlayerStatus.Hide)
        {
            StartCoroutine("GameOver");
        }
    }

    private IEnumerator GameOver()
    {
        StopClass.Stop = true;

        yield return new WaitForSeconds(1.0f);
        Animator anim = Enemy.GetComponent<Animator>();
        anim.SetTrigger("GameOver");

        yield return new WaitForSeconds(2f);

        //ゲームオーバー
        FadeOut fo = FadePanel.GetComponent<FadeOut>();
        fo.begin(SceneChangeManager.SceneChange, SceneChangeManager.Scenes.GameOver);
    }
}
