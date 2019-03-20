using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ObjectMove))]

public class MainGameManager : MonoBehaviour {


    #region　キャッシュ
    public ObjectMove Move { get { return this.objectMove ?? (this.objectMove = GetComponent<ObjectMove>()); } }
    ObjectMove objectMove;
    #endregion

    [SerializeField]
   private Text text;

    public int a;
    public GameObject aaa;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Move.GetTouchPosition();

        if(PlayerStatus.Hide)
        {
            text.text = "true";
        }
        else
        {
            text.text = "false";
        }
    }
}
