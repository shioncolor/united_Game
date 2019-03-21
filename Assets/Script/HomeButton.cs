using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeButton : MonoBehaviour {

    [SerializeField]
    GameObject UI;

    bool flag=true;
     public void PushButton()
    {
        if (flag)
        {
            StopClass.Stop = true;
            UI.SetActive(true);
            flag = false;
        }
        else
        {
            UI.SetActive(false);
            StopClass.Stop = false;
            flag = true;
        }
    }
}
