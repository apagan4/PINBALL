using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    Rigidbody2D Ball;
    Vector2 old;

    void Start()
    {
        Ball = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        old = Ball.velocity; //saving original velocity to a vector
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Bumper"))
        {
            ContactPoint2D cont = col.contacts[0];
            Ball.velocity = Vector2.Reflect(old, cont.normal); //Vector 2 reflects back to the normal

            Ball.velocity += cont.normal * 3.0f;  //Speeds ball up 

        }
    }
}
