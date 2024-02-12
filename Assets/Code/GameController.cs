using System.Collections;
using System.Collections.Generic;
//using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject enemy;
    public float spawmTime;
    float m_spawnTime;
    int m_score;
    bool m_isGameover1;
    UI m_ui;
    // Start is called before the first frame update
    void Start()
    {
        m_ui = FindObjectOfType<UI>();
        m_ui.SetScoreText("Score: " + m_score);
        m_spawnTime=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(m_isGameover1)
        {
            m_spawnTime=0;
            m_ui.ShowGameOverPanel(true);
            return;
        }
        m_spawnTime-=Time.deltaTime;
        if(m_spawnTime <=0 )
        {
            SpawnEnemy();
            m_spawnTime=spawmTime;
        }
    }
    public void Replay()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void SpawnEnemy()
    {
        float randXpos=Random.Range(-8f,8f);
        Vector2 spawnPos=new Vector2(randXpos,7);
        if(enemy)
        {
            Instantiate(enemy,spawnPos,Quaternion.identity);
        }
    }
    public void SetScore(int value)
    {   
        m_score=value;
    }
    public int getScore()
    {
        return m_score;
    }
    public void ScorrIncrement()
    {
        m_score++;
        m_ui.SetScoreText("Score: " + m_score);
    }
    public void SetGameoverState(bool state)
    {
        m_isGameover1=state;
    }
    public bool IsGameover()
    {
        return m_isGameover1;
    }
}

internal class UIManager
{
    internal void SetScoreText(string v)
    {
        throw new System.NotImplementedException();
    }
}