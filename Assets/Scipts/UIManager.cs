using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextEnd;
    public GameObject gameOverPanel;
    public GameObject gameStartPanel;
    public GameObject TextScore;
    public GameObject TextScoreEnd;
    public void SetScoreText(string text)
    {
        if (scoreText)
        {
            scoreText.text = text;
            scoreTextEnd.text = text;
        }
    }

    public void SetText(bool show) 
    {
        TextScore.SetActive(show);
    }
    
    public void SetTextEnd(bool show) 
    {
        TextScoreEnd.SetActive(show);
    }
    public void SetGamestartPanel(bool set)
    {
        if (gameStartPanel)
        {
            gameStartPanel.SetActive(set);
        }
    }

    public void ShowGameOverPanel(bool show)
    {
        if (gameOverPanel)
        {
            gameOverPanel.SetActive(show);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
