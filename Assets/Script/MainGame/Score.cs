using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Score
{

    private static int scoreTime;
    static string key = "HIGH SCORE";

    void Start()
    {
        scoreTime = PlayerPrefs.GetInt(key, 0);
    }

    public static float GetScoreTime()
    {
        return scoreTime;
    }

    public static void SetScoreTime(float time)
    {
        if (scoreTime < time)
        {
            scoreTime = (int)time;
            PlayerPrefs.SetInt(key, scoreTime);
        }
    }

}
