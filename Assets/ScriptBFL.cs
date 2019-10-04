using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBFL : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cat_GG")
        {
            Physics2D.IgnoreLayerCollision(9, 10);
        }
    }
}
