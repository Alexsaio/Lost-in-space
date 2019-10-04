using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElementManager : MonoBehaviour
{
    public static ElementManager instance;
    public TextMeshProUGUI text;
    int countElements = 0;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeCountElements(int elementsValue)
    {
        countElements += elementsValue;
        text.text = "X" + countElements.ToString();

    }
}
