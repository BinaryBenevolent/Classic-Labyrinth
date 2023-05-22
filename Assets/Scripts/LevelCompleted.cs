using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LevelCompleted : MonoBehaviour
{
    [SerializeField] private Image oneStar;
    [SerializeField] private Image twoStar;
    [SerializeField] private Image threeStar;

    [SerializeField] private Sprite emptyStar;
    [SerializeField] private Sprite filledStar;

    public void InitializeStar()
    {
        oneStar.sprite = emptyStar;
        twoStar.sprite = emptyStar;
        threeStar.sprite = emptyStar;
    }

    public void OneStar()
    {
        oneStar.sprite = filledStar;
    }

    public void TwoStar()
    {
        OneStar();
        twoStar.sprite = filledStar;
    }

    public void ThreeStar()
    {
        TwoStar();
        threeStar.sprite = filledStar;
    }
}
