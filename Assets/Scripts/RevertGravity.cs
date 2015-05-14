using UnityEngine;
using System.Collections;

public class RevertGravity : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void Revert()
    {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = -rb.gravityScale;
    }
}
