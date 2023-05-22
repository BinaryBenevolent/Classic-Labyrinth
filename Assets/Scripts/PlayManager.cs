using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PlayManager : MonoBehaviour
{
    [SerializeField] private UnityEvent OnGameOver = new UnityEvent();
    [SerializeField] private UnityEvent OnPlayerWin = new UnityEvent();

    [SerializeField] private LevelCompleted levelCompleted;

    [SerializeField] private TMP_Text scoreText;

    [SerializeField] private int starCollected;
    [SerializeField] private int score;

    public int StarCollected { get => starCollected; set => starCollected = value; }
    public int Score { get => score; set => score = value; }

    private void Start()
    {
        score = 0;
        starCollected = 0;
        levelCompleted.InitializeStar();
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        OnGameOver.Invoke();
    }

    public void PlayerWin()
    {
        Time.timeScale = 0f;
        OnPlayerWin.Invoke();

        if(starCollected == 1)
        {
            levelCompleted.OneStar();
        }
        else if (starCollected == 2)
        {
            levelCompleted.TwoStar();
        }
        else if (starCollected == 3)
        {
            levelCompleted.ThreeStar();
        }

        scoreText.text = Convert.ToString(score);
    }
}
