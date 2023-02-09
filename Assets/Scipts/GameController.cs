using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public GameObject square;
    public float spawmTime;

    private float m_spawnTime;
    private int m_score;
    public bool m_start;
    public bool m_gameOver;
    private UIManager m_ui;
    public void SpawnBall()
    {
        Vector2 spawPos = new Vector2(Random.Range(-7, 7), 6);

        if (ball)
        {
            GameObject spawnBallNew = Instantiate(ball, spawPos, Quaternion.identity);
            
        }
    }
    public void IncreamentScore()
    {
        m_score++;
        m_ui.SetScoreText("Score: " + m_score);
    }

    public void NewStart()
    {
        m_start = false;
        m_ui.SetText(true);
        m_ui.SetGamestartPanel(false);
        square.SetActive(true);
    }
    public void Replay()
    {
        m_score = 0;
        m_gameOver = false;
        m_ui.SetScoreText("Score: " + m_score);
        m_ui.SetText(true);
        m_ui.ShowGameOverPanel(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        m_start = true;
        m_spawnTime = 0;
        m_ui = FindObjectOfType<UIManager>();
        m_ui.SetScoreText("Score: " + m_score);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_start)
        {
            return;
        }
        m_spawnTime -= Time.deltaTime;
        if (m_gameOver)
        {
            m_ui.ShowGameOverPanel(true);
            m_ui.SetText(false);
            m_spawnTime = 0;
            return;
        }
        if (m_spawnTime <= 0)
        {
            SpawnBall();
            m_spawnTime = spawmTime;
        }
    }
}
