using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RightPaddlePress : MonoBehaviour {
    HingeJoint2D[] hingeJoints;
    JointMotor2D jointMotor;

    void Start () {
        hingeJoints = gameObject.GetComponents<HingeJoint2D>();
        jointMotor = hingeJoints[0].motor;
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            jointMotor.motorSpeed = 2000;  //Increase motor speed
            GetComponent<AudioSource>().Play(); //Plays Audio everykey press
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            jointMotor.motorSpeed = -2000; //decrease in motor speed (swings back)
        }
        hingeJoints[0].motor = jointMotor; 
    }
}
