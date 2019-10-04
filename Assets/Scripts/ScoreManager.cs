using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using NUnit.Framework;

public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager instance;
        public TextMeshProUGUI text;
        public static int score;

        void Start()
        {
            score = 0;
            if (instance == null)
            {
                instance = this;
            }
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

