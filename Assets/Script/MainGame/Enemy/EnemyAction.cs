using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour
{

    public Animator anim { get { return this._anim ?? (this._anim = GetComponent<Animator>()); } }
    Animator _anim;


    //振り返っているかどうか
    private static bool trun = false;
    public static bool Trun
    {
        get { return trun; }

        private set { trun = value; }
    }

    private float[] ForwardTime = { 3.0f, 2.5f, 4.0f };
    private float[] SideTIme = { 3.0f, 2.5f, 2.5f };
    private float[] BehideTIme = { 3.0f, 4.0f, 2.5f };


    private bool ActionFlag = true;

    void Start()
    {
        StartCoroutine("start");

    }

    void Update()
    {
        if (!ActionFlag)
        {
            ActionFlag = true;
            StartCoroutine("Side");
        }
    }


    private void Forward()
    {
        Trun = false;
    }
    private void Behide()
    {
        Trun = true;
    }

    private IEnumerator Side()
    {
        int ramdom = Random.Range(0, 3);
        anim.SetTrigger("Behide_Side");
        //横を向いている時間
        yield return new WaitForSeconds(SideTIme[ramdom]);

        if (Random.Range(0, 6) >= 3)
        {
            anim.SetTrigger("Side_Forward");
            Behide();
            
            //こっちをを向いている時間
            yield return new WaitForSeconds(BehideTIme[ramdom]);
            anim.SetTrigger("Forward_Behide");
            Forward();
        }
        else
        {
            anim.SetTrigger("Side_Behide");
        }
        //後ろを向いている時間
        yield return new WaitForSeconds(ForwardTime[ramdom]);
        ActionFlag = false;
    }



    private IEnumerator start()
    {
        yield return new WaitForSeconds(3);
        ActionFlag = false;
    }
}
