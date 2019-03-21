using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MainGameManager : MonoBehaviour {


    [SerializeField]
    private GameObject[] Player;

    private float time;
    // Use this for initialization
    void Start () {

        //playerの生成
        int random = Random.Range(0,Player.Length);
        Instantiate(Player[random]);
    }
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if (EnemyAction.Trun && !PlayerStatus.Hide)
        {
            //ゲームオーバー
            //SceneChangeManager.SceneChange(SceneChangeManager.Scenes.GameOver);
        }

    }
}
