using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdie : MonoBehaviour
{

    public GameObject gameover;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "player")
        {
            AudioManager._instance.setAudio(AudioClipType.hit);
            if (!gameover.activeSelf)
            {
                gameover.SetActive(true);
                //AudioManager._instance.setAudio(AudioClipType.die);
            }
            Mapmove map1 = GameObject.Find("map1").GetComponent<Mapmove>();
            map1.enabled = false;
            Mapmove map2=GameObject.Find("map2").GetComponent<Mapmove>();
            map2.enabled = false;
            Rigidbody2D playerRigidbody2D = GameObject.Find("player").GetComponent<Rigidbody2D>();
            Destroy(playerRigidbody2D);
        }
    }
}
