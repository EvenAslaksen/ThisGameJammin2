using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fork : MonoBehaviour
{
    private Vector2 mousePosition;
    public float speed;
    public Rigidbody2D fork;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            fork.AddForce (Vector2.up * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            fork.AddForce(Vector2.down * speed);
        }
    }
}
