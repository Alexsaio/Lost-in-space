using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerCat : MonoBehaviour
{
    public static AudioClip Cat;
    static AudioSource audioSource;

    void Start()
    {
        Cat = Resources.Load<AudioClip>("Cat");
        audioSource = GetComponent<AudioSource>();
    }

    public static void playSound()
    {
        audioSource.PlayOneShot(Cat);
    }
}
