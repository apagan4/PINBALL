using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperBounce : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D col)
    {
        myRigidbody.AddForce.(col.contacts[0].normal * bumperForce, ForceMode.Impulse);
    }
}
