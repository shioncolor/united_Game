using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ISvisible : MonoBehaviour {



    private Vector3 pos = new Vector3(52, 0, 0);
    
    void OnBecameInvisible()
    {
        transform.position += pos;
    }
}
