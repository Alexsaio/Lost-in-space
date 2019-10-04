using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerCoin : MonoBehaviour
{
    public static AudioClip coin;
    static AudioSource audioSource;

    void Start()
    {
        coin = Resources.Load<AudioClip>("монета");
        audioSource = GetComponent<AudioSource>();
    }

    public static void playSound()
    {
        audioSource.PlayOneShot(coin);
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
