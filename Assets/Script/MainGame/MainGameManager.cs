using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ObjectMove))]

public class MainGameManager : MonoBehaviour {

    #region
    public ObjectMove Move { get { return this.objectMove ?? (this.objectMove = GetComponent<ObjectMove>()); } }
    ObjectMove objectMove;
    #endregion

    [SerializeField]
    Text text;
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
