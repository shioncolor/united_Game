using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{

    [SerializeField]
    GameObject BackGround;

    //BackGroundの移動速度
    private Vector3 BackGroundMoveDirection = new Vector3(0.095f, 0.0f, 0.0f);
    
    void Start()
    {
  
    }

    void Update()
    {
        if (JudgPressPosition.Press() && !StopClass.Stop)
        {
            if(JudgPressPosition.PositionJug())
            {
                BackGround.transform.position += BackGroundMoveDirection;
            }
            else
            {
                BackGround.transform.position -= BackGroundMoveDirection;
            }
        }
    }
}
