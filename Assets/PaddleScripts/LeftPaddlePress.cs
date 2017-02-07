using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddlePress : MonoBehaviour {

    HingeJoint2D[] hingeJoints;
    JointMotor2D jointMotor;
	void Start () {
        hingeJoints = gameObject.GetComponents<HingeJoint2D>();
        jointMotor = hingeJoints[0].motor;
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            jointMotor.motorSpeed = -2000;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            jointMotor.motorSpeed = 2000;
        }
        hingeJoints[0].motor = jointMotor;
    }
}
