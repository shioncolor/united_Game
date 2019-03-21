using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MainGameManager : MonoBehaviour {


    [SerializeField]
   private Text text;

    public int a;
    public GameObject aaa;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
       // Move.GetTouchPosition();

        if(EnemyAction.Trun && !PlayerStatus.Hide)
        {
            //ゲームオーバー
            SceneChangeManager.SceneChange(SceneChangeManager.Scenes.GameOver);
        }
    }
}
