using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIstart : MonoBehaviour {

    public GameObject panel_start;//开始
    public GameObject panel_rate;//说明
    public GameObject panel_rank;//排行榜
    public Text score;
    public Text maxscore;

    void Start()
    {
        Screen.SetResolution(480, 800, false);
    }

    //点击打开说明
    public void ClickOpenPanel_Rate()
    {
        if (!panel_rate.activeSelf)
        {
            panel_rate.SetActive(true);
        }
        if(panel_start.activeSelf)
        {
            panel_start.SetActive(false);
        }
    }

    //点击打开排行榜
    public void ClickOpenPanel_Rank()
    {
        score.text = gamesever.GetSingleton().score.ToString();
        maxscore.text= gamesever.GetSingleton().maxscore.ToString();
        if (!panel_rank.activeSelf)
        {
            panel_rank.SetActive(true);
        }
        if (panel_start.activeSelf)
        {
            panel_start.SetActive(false);
        }
    }

    //关闭排行榜
    public void ClickClosePanel_Rank()
    {
        if (panel_rank.activeSelf)
        {
            panel_rank.SetActive(false);
        }
        if (!panel_start.activeSelf)
        {
            panel_start.SetActive(true);
        }
    }

    //点击开始游戏
    public void ClickStartGame()
    {
        gamesever.GetSingleton().ResetScore();
        SceneManager.LoadScene("main");
    }
}
