using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fork : MonoBehaviour
{
    private Vector2 mousePosition;
    public float speed;
    public Rigidbody2D fork;
    private SliderJoint2D forkSlider;
    private JointMotor2D forkMotor;

    private void Start()
    {
        forkSlider = GetComponent<SliderJoint2D>();
        forkMotor = forkSlider.motor;
    }

    void Update()
    { //This doesn't work
        if (Input.GetKey(KeyCode.W))
        {
            forkMotor.motorSpeed = -speed;
            forkSlider.motor = forkMotor;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            forkMotor.motorSpeed = speed;
            forkSlider.motor = forkMotor;
        }
        else
        {
            forkMotor.motorSpeed = 0;
            forkSlider.motor = forkMotor;
        }
    }
}
