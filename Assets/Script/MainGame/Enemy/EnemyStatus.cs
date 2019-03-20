using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour {

    //振り返っているかどうか
    private static bool trun=false;
    public static bool Trun
    {
        get { return trun; }

        private set { trun = value; }
    }
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
