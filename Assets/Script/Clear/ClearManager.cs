using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearManager : MonoBehaviour
{

    [SerializeField]
    private GameObject[] PlayerStand;
    [SerializeField]
    private GameObject[] PlayerRunning;
    
    private int index;
    // Use this for initialization
    void Start()
    {
        index = SelectStageStatus.PlayerNum + SelectStageStatus.StageNum - 1;
        PlayerStand[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
