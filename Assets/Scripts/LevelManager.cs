using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary> Manages the state of the level </summary>
public class LevelManager : MonoBehaviour
{
    public int Score { get; private set; }
    public Text scoreText;
    public GameObject gameover;
    public GameObject pause;
    private bool isPaused = false;
    private bool isGameover = false;

    void Start()
    {
        isGameover = false;
        gameover.SetActive(false);
        pause.SetActive(false);

    }

    void Update()
    {
        scoreText.text = "Score: " + Score.ToString();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
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
        gameover.SetActive(true);
        isGameover = true;
 
    }

    public void PauseGame()
    {
        if (isPaused && !isGameover)
        {
            pause.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
        }
        else if (!isPaused && !isGameover)
        {
            pause.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;

        }
    }

    public void LaodLevel(string str)
    {
        Application.LoadLevel(str);
    }
}
