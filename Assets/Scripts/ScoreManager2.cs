using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager2 : MonoBehaviour
{
    public static ScoreManager2 instance;
    public TextMeshProUGUI text;
    public int score;

    void Start()
    {
        
        if (instance == null)
        {
            instance = this;
        }
        score = PlayerPrefs.GetInt("score");
        text.text = "X" + score.ToString();
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "X" + score.ToString();

    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("score", score);
    }
}
