using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ready : MonoBehaviour
{
    [SerializeField]
    GameObject Go;

    public void RedyGo()
    {
        StartCoroutine("RedyGoCoroutine");
    }

    private IEnumerator RedyGoCoroutine()
    {

        yield return new WaitForSeconds(1f);
        Go.SetActive(true);
        yield return new WaitForSeconds(1f);
        Go.SetActive(false);
        yield return new WaitForSeconds(1f);
        StopClass.Stop = false;
    }
}
