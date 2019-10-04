using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cat_GG"))
        {
            ScoreManager.instance.ChangeScore(coinValue);
            ScoreManager2.instance.ChangeScore(coinValue);
            ScoreManager3.instance.ChangeScore(coinValue);
        }
    }
}
