using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    //隠れているかどうか
    private static bool hide= false;
    public static bool Hide
    {
        get { return hide; }

        private set { hide = value; }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Hide = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Hide = false;
    }
}
