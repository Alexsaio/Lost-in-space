using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;

    private bool movingRight = true;
    public float distance;
    public Transform groundDeetction;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDeetction.position, Vector2.right, distance);
        RaycastHit2D leftgroundInfo = Physics2D.Raycast(groundDeetction.position, Vector2.left, distance);
        RaycastHit2D downgroundInfo = Physics2D.Raycast(groundDeetction.position, Vector2.down, distance); 
        if (groundInfo.collider == false || leftgroundInfo.collider == false || downgroundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }

        /*if (leftgroundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }*/
    }

}
