using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class JudgPressPosition
{
    public static bool Press()
    {
        if (Input.GetMouseButton(0))
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
        if (Screen.height / 2 <= (int)Input.mousePosition.x)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

