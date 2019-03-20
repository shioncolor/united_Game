using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{

    private static bool hide;
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
