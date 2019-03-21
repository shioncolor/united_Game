using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MainGameManager : MonoBehaviour {


    [SerializeField]
   private Text text;

    [SerializeField]
    private GameObject[] Player;

    // Use this for initialization
    void Start () {
        //playerの生成
        int random = Random.Range(0,2);
        Instantiate(Player[random]);
    }
	
	// Update is called once per frame
	void Update () {
       // Move.GetTouchPosition();

        if(EnemyAction.Trun && !PlayerStatus.Hide)
        {
            //ゲームオーバー
            //SceneChangeManager.SceneChange(SceneChangeManager.Scenes.GameOver);

            text.text = "ゲームオーバー";
        }
        else
        {
            text.text = "";

        }
    }
}
