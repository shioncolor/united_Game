using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{

    [SerializeField]
    GameObject BackGround;

    Vector3 pos;//初期値

    //BackGroundの移動速度
    private Vector3 BackGroundMoveDirection = new Vector3(0.095f, 0.0f, 0.0f);
    
    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        if (StopClass.Stop)
            return;

        if (JudgPressPosition.Press() && !StopClass.Stop)
        {
            if(JudgPressPosition.PositionJug())
            {
                BackGround.transform.position += BackGroundMoveDirection;
            }
            else if(pos.x< BackGround.transform.position.x - BackGroundMoveDirection.x)
            {
                BackGround.transform.position -= BackGroundMoveDirection;
            }
        }
    }
}
