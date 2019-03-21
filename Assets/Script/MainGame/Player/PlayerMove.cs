using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    GameObject chara;
    [SerializeField]
    GameObject Player;

    public Animator anim { get { return this._anim ?? (this._anim = chara.GetComponent<Animator>()); } }
    Animator _anim;

 
    //移動速度
    private Vector3 MoveDirection = new Vector3(0.1f, 0.0f, 0.0f);

    //playerの初期値
    private Vector3 CameraPos;

 
    void Start()
    {

    }

    void Update()
    {
        if (JudgPressPosition.Press())
        {
            anim.SetBool("Is_run", true);

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
        else
        {
            anim.SetBool("Is_run", false);
        }
    }
}

