using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElementScript : MonoBehaviour
{
    public int elementsValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cat_GG"))
        {
            SoundManagerCat.playSound();
            Invoke("MyLoad", 1/2);
        }
    }

    public void MyLoad()
    {
        if (gameObject.CompareTag("Element1"))
        {
            SceneManager.LoadScene("secondLevel");
        }
        else if (gameObject.CompareTag("Element2"))
        {
            SceneManager.LoadScene("thirdLevel");
        }
        else if (gameObject.CompareTag("Element3"))
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
