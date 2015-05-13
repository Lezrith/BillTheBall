using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour
{
    Vector2 force, mousePos, direction;
    Rigidbody2D ballRigidbody;
    public float pushForce;
    // Use this for initialization
    void Start()
    {
        ballRigidbody = this.GetComponent<Rigidbody2D>();
        direction = new Vector2(0, 1);
        ballRigidbody.AddForce(direction * 5);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            mousePos = Camera.main.ScreenToWorldPoint( Input.mousePosition);
            direction = (Vector2)this.transform.position - mousePos;
            direction.Normalize();
            ballRigidbody.AddForce(direction*pushForce);
        }
    }
}
