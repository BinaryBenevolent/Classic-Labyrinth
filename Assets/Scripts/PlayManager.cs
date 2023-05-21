using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayManager : MonoBehaviour
{
    [SerializeField] private UnityEvent OnGameOver = new UnityEvent();
    [SerializeField] private UnityEvent OnPlayerWin = new UnityEvent();

    public void GameOver()
    {
        Time.timeScale = 0f;
        OnGameOver.Invoke();
    }

    public void PlayerWin()
    {
        Debug.Log("Player Win");
        Time.timeScale = 0f;
        OnPlayerWin.Invoke();
    }
}
