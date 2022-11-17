using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fork : MonoBehaviour
{
    public float speed;
    public SliderJoint2D forkSlider;
    public Rigidbody2D fork;
    
    private JointMotor2D forkMotor;
    private float distance;
    private Vector2 forkPos;

    private void Start()
    {
        forkMotor = forkSlider.motor;        
    }

    void FixedUpdate()
    {        
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 forkPos = this.transform.position;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.x = 0;
        forkPos.x = 0;
        distance = Vector2.Distance(mousePos, forkPos);
        speed = distance * 2;

        if (Input.GetMouseButton(0) & distance > 0.3)
        {
            if (mousePos.y < forkPos.y)
            {
                forkMotor.motorSpeed = speed;
                forkSlider.motor = forkMotor;
            }
            else if (mousePos.y > forkPos.y)
            {
                forkMotor.motorSpeed = -speed;
                forkSlider.motor = forkMotor;
            }

        }
        else
        {
            forkMotor.motorSpeed = 0;
            forkSlider.motor = forkMotor;
        }        
    }
}
