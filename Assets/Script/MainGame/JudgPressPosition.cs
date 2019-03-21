using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class JudgPressPosition
{
    public static bool Press()
    {
        if (Input.GetMouseButton(0) && Screen.height / 2 >= (int)Input.mousePosition.y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool PositionJug()
    {
        if (Screen.width / 2 <= (int)Input.mousePosition.x)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

