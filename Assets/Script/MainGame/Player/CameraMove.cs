using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    [SerializeField]
    GameObject Camera;

    private Vector3 pos = new Vector3(0.095f, 0.0f, 0.0f);
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetTouchPosition();
    }

    public void GetTouchPosition()
    {
        if (Input.GetMouseButton(0))
        {
            if (Screen.height / 2 <= (int)Input.mousePosition.x)
            {
                Camera.transform.position += pos;
            }
            else
            {
                Camera.transform.position -= pos;
            }

        }

    }
}
