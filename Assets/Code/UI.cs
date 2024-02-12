using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    public Text score;
    public GameObject gameover;
    public void SetScoreText(string txt)
    {
        if(score){
            score.text=txt;
        }
    }
    public void ShowGameOverPanel(bool isShow)
    {
        if(gameover)
        {
            gameover.SetActive(isShow);
        }
    }
}
