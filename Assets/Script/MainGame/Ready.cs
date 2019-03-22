using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ready : MonoBehaviour
{
    [SerializeField]
    GameObject Go;
    [SerializeField]
    GameObject ruru;

    [SerializeField]
    GameObject HomeButton;

    public void RedyGo()
    {
        StartCoroutine("RedyGoCoroutine");
    }

    private IEnumerator RedyGoCoroutine()
    {

        yield return new WaitForSeconds(1f);
        Go.SetActive(true);
        ruru.SetActive(true);
        yield return new WaitForSeconds(2f);
        Go.SetActive(false);
        ruru.SetActive(false);
        yield return new WaitForSeconds(1f);
        StopClass.Stop = false;
        HomeButton.SetActive(true);
    }
}
