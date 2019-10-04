using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager3 : MonoBehaviour
{
    public static ScoreManager3 instance;
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
}
