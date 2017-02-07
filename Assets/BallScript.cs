using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    Rigidbody2D Ball;
    Vector2 old;
    public Text ScoreText;
    private int Score;

    void Start()
    {
        Ball = GetComponent<Rigidbody2D>();
        Score = 0;
        
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
            Score = Score + 100;
            SetScoreText();
        }
        if (col.transform.CompareTag("Trigger"))
        {
            ContactPoint2D cont = col.contacts[0];
            Ball.velocity = Vector2.Reflect(old, cont.normal); //Vector 2 reflects back to the normal
            Ball.velocity += cont.normal * 3.0f;  //Speeds ball up 
            Score = Score + 50;
            SetScoreText();
        }
    }
    void SetScoreText()
    {
        ScoreText.text = "SCORE: " + Score.ToString();
    }
}
