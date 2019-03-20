using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

    [SerializeField]
    GameObject Player;

    private Vector3 pos = new Vector3(0.1f, 0.0f,0.0f);
	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
        GetTouchPosition();
	}

    public void GetTouchPosition()
    {
        if(Input.GetMouseButton(0))
        {
            if(Screen.height/2<= (int)Input.mousePosition.x)
            {
                Player.transform.position += pos;
            }
            else
            {
                Player.transform.position -= pos;
            }

        }

    }
}
