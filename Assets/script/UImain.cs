using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImain : MonoBehaviour {

    public Text score;

    public void ClickRestart()
    {
        gamesever.GetSingleton().ResetScore();
        SceneManager.LoadScene("main");
    }

    public void ClickBack()
    {
        SceneManager.LoadScene("start");
    }

	// Update is called once per frame
	void Update () {
        score.text = gamesever.GetSingleton().score.ToString();
    }
}
