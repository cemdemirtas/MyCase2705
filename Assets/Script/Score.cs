using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreAndCountdown : MonoBehaviour
{
    public static ScoreAndCountdown instance;
    int score;
    float Countdown = 150;
    public TextMeshProUGUI scoretxt, countdowntxt;

    private void Awake() //Singleton
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Update()
    {
        Countdown -= Time.deltaTime;
        countdowntxt.text = "TIME : " + Mathf.Round(Countdown);

        if (Countdown < 0)
        {
            Debug.Log("Game Over");
        }
        if (Countdown<=0)
        {
            Countdown = 0;
        }
    }
    public int ScoreAdd(int scr) //Increase Score by reference other script
    {
        score += scr;
        ControlScore();
        return score;
    }

    public int ScoreSubstract(int scr) //Decrease Score by reference other script
    {
        score -= scr;
        ControlScore();
        return score;
    }

    private void ControlScore() //Text write
    {
        scoretxt.text = "Score : " + score;
    }
    void CountDown()
    {

    }
}
