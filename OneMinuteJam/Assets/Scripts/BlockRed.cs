using UnityEngine;

public class BlockRed : MonoBehaviour
{
    void FixedUpdate()
    {
        gameObject.transform.localPosition += Vector3.down * .1f;
    }
}
