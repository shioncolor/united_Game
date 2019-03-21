using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    private Vector3 pos = new Vector3(0.1f, 0, 0);
	
	// Update is called once per frame
	void Update () {
        transform.position += pos;
	}
}
