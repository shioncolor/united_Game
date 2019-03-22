using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMove : MonoBehaviour
{

    public Animator anim { get { return this._anim ?? (this._anim = GetComponent<Animator>()); } }
    Animator _anim;

    private Rigidbody2D rb2d;

    private float flap = 20f;
    private bool jump = false;

    float time = 0;
    float jumpTime = 0.5f;//一回のジャンプの上限


    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (StopClass.Stop)
        {
            anim.SetBool("Is_run", false);
            return;
        }
        else
        {
            anim.SetBool("Is_run", true);
        }

        if (time < jumpTime)
        {
            if (JudgPressPosition.Press() || !jump)
            {
                time += Time.deltaTime;
                rb2d.AddForce(Vector2.up * flap);
                jump = true;
            }
        }

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        jump = false;
        time = 0;

    }
}
