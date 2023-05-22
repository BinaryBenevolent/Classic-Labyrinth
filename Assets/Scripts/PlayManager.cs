using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayManager : MonoBehaviour
{
    [SerializeField] private UnityEvent OnGameOver = new UnityEvent();
    [SerializeField] private UnityEvent OnPlayerWin = new UnityEvent();

    [SerializeField] private LevelCompleted levelCompleted;

    [SerializeField] private int starCollected;

    public int StarCollected { get => starCollected; set => starCollected = value; }

    private void Start()
    {
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
    }
}
