using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitflag : MonoBehaviour {

    private static bool Charahit = false;
    public static bool Hit
    {
        get { return Charahit; }

        private set { Charahit = value; }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Charahit = true;
        }
    }

}
