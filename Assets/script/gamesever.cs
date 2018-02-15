using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamesever{

    private static gamesever _instance;
    public static gamesever GetSingleton()
    {
        if (_instance == null)
        {
            _instance = new gamesever();
        }
        return _instance;
    }
    private gamesever()
    {
        score = 0;
        maxscore = 0;
    }
    public float score;
    public float maxscore;

    public void SetMaxScore()
    {
        if (score >= maxscore)
        {
            maxscore = score;
        }
    }

    public void ResetScore()
    {
        score = 0;
    }
}
