using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperBounce : MonoBehaviour {

   
    void OnCollisionEnter2D(Collision2D col)
    {
        col.rigidbody.AddForce(transform.up);
    } 
}
