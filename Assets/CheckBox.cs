using UnityEngine;

public class CheckBox : MonoBehaviour
{
    public float speed;
    private bool movingRight = true;

    void OnCollisionEnter2D(Collision2D collision)
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (collision.gameObject.tag == "CheckBox")
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
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
