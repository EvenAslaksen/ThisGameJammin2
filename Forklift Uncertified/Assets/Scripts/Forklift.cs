using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forklift : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;
    private Vector3 scale;
    private float xScale;
    private float zRotation;
    Transform target;
    //public static Quaternion Inverse(Quaternion rotation);
    

    private void Start()
    {
        xScale = 5f;
        scale = new Vector3(xScale, 5f, 5f);
    }
    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.W))
        {
        xScale = xScale * -1;
        scale = new Vector3(xScale, 5f, 5f);
        this.transform.localScale = scale;
        }*/
    }

    void FixedUpdate()
    {
        zRotation = -this.transform.rotation.z;
        //Debug.Log(rotation);

        if (Input.GetKey(KeyCode.A))
        {
            body.AddForce(Vector2.left * speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            body.AddForce(Vector2.right * speed);
        }

        if(zRotation < -0.7070528 || zRotation > 0.7070528)
        {
            Debug.Log("He turn doe");
            //this.transform.rotation = Quaternion.Inverse(target.rotation);

            xScale = xScale * -1;
            scale = new Vector3(xScale, 5f, 5f);
            transform.localScale = scale;
            this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, zRotation);
        }
    }
}
