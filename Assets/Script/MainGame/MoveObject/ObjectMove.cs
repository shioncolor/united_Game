using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour {

    [SerializeField]
    GameObject Player;
    [SerializeField]
    GameObject BackGround;

    private Vector3 PlayerMoveDirection = new Vector3(0.1f, 0.0f, 0.0f);
    private Vector3 BackGroundMoveDirection = new Vector3(0.095f, 0.0f, 0.0f);

    //画面の半分の値
    private int Height = Screen.height / 2;

    //押した位置で左右のどちらかに進む
    public void GetTouchPosition()
    {
        if (Input.GetMouseButton(0))
        {
            if (Height <= (int)Input.mousePosition.x)
            {
                Player.transform.position += PlayerMoveDirection;
                BackGround.transform.position += BackGroundMoveDirection;
            }
            else
            {
                Player.transform.position -= PlayerMoveDirection;
                BackGround.transform.position -= BackGroundMoveDirection;
            }
        }
    }
}
