using UnityEngine;

public class Player2 : MonoBehaviour
{
    private float walkSpeed = 8f;

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * walkSpeed);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * walkSpeed);
        }
    }
}
