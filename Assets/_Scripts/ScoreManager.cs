using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ScoreManager : MonoBehaviour

{
    public static ScoreManager instance;
    public TMP_Text ChangingText;
    public TMP_Text ChangingLife;
    int score = 0;
    public int life = 5;
    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        Debug.Log(score);
    }

    public void FinalScore(int Life)
    {
        score += Life * 2;
        Debug.Log(score);
    }

    public int ReturnLife()
    {
        return life;
    }

    public void Update()
    {
        ChangingText.text = score.ToString();
        ChangingLife.text = life.ToString();
    }
}
