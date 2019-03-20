using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour
{
    [SerializeField]
    GameObject Chara;
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


    private bool ActionFlag = false;

    void Update()
    {
        if (!ActionFlag)
        {
            ActionFlag = true;
            Chara.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90.0f);
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

        //横を向いている時間
        yield return new WaitForSeconds(SideTIme[ramdom]);

        if (Random.Range(0, 3) == 0)
        {
            Chara.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180.0f);
            Behide();
            
            //こっちをを向いている時間
            yield return new WaitForSeconds(BehideTIme[ramdom]);
            Forward();
        }

        Chara.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        //後ろを向いている時間
        yield return new WaitForSeconds(ForwardTime[ramdom]);
        ActionFlag = false;
    }
}
