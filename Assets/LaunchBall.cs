using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour {
    SliderJoint2D[] sliderJoint;
    JointMotor2D jointMotor;
    void Start()
    {
        sliderJoint = gameObject.GetComponents<SliderJoint2D>();
        jointMotor = sliderJoint[0].motor;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            jointMotor.motorSpeed = -500;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            jointMotor.motorSpeed = 500;
        }
        else
            jointMotor.motorSpeed = 0;

        
        sliderJoint[0].motor = jointMotor;
    }

}
