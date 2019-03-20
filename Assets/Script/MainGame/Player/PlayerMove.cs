using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField]
    GameObject chara;
    [SerializeField]
    GameObject Player;

    //移動速度
    private Vector3 MoveDirection = new Vector3(0.1f, 0.0f, 0.0f);

    //playerの初期値
    private Vector3 CameraPos;

    private bool CameraMoveflag = false;
    void Start()
    {
       
    }

    void Update()
    {
        if (JudgPressPosition.Press())
        {
            if (JudgPressPosition.PositionJug())
            {
                chara.transform.rotation = Quaternion.Euler(0.0f, 0, 0.0f);
                Player.transform.position += MoveDirection;

            }
            else
            {
                chara.transform.rotation = Quaternion.Euler(0.0f, 180, 0.0f);
                Player.transform.position -= MoveDirection;
            }
        }
    }
}

