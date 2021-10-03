using UnityEngine;

public class Player1 : MonoBehaviour
{
    private float walkSpeed = 8f;

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * walkSpeed);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * walkSpeed);
        }
    }
}
