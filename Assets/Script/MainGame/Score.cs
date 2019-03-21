using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score
{

    private static float scoreTime;

    public static float GetScoreTime()
    {
        return scoreTime;
    }

    public static void SetScoreTime(float time)
    {
        if (scoreTime < time)
            scoreTime = time;
    }

}
