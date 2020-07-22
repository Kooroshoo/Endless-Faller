using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary> Manages the state of the level </summary>
public class LevelManager : MonoBehaviour
{
    public int Score { get; private set; }
    public Text scoreText;
    public GameObject gameoverText;
    public GameObject pauseText;

    void Start()
    {
        gameoverText.SetActive(false);
        pauseText.SetActive(false);

    }

    void Update()
    {
        scoreText.text = "Score: " + Score.ToString();
    }

    public void IncrementScore()
    {
        Score++;
    }

    private void Reset()
    {
        Score = 0;
        // reset logic
    }

    public void GameOver()
    {
        gameoverText.SetActive(true);
    }
}
