using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addscore : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {
            //加分
            gamesever.GetSingleton().score += 1;
            //Debug.Log(gamesever.GetSingleton().score);
            gamesever.GetSingleton().SetMaxScore();
            AudioManager._instance.setAudio(AudioClipType.point);
        }
    }
}
