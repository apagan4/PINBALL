using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    Rigidbody2D Ball;
    Vector2 old;
    public Text ScoreText;
    public Text BallsText;
    private int Score; //score obtained
    private int Balls; //lives left


    void Start()
    {
        Ball = GetComponent<Rigidbody2D>();
        Score = 0; //Begin with 0 
        Balls = 3; //3 lives
        
    }

  

    void Update()
    {
        SetScoreText(); //Always have Score on the Screen As opposed to only being up when colliding
        SetBallsText(); //Always have number of lives on screen

        if (Balls == 0) //When lives run out
        {
            Score = 0;  //Score reset back to 0
            Balls = 3;  //Balls reset to 3
        }

        
    }

    private void FixedUpdate()
    {
        old = Ball.velocity; //saving original velocity to a vector
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Most if statements look for a collision with a Tag, Predetermined points are given and velocity is increased.
        if (col.transform.CompareTag("Bumper"))
        {
            ContactPoint2D cont = col.contacts[0];
            Ball.velocity = Vector2.Reflect(old, cont.normal); //Vector 2 reflects back to the normal
            Ball.velocity += cont.normal * 3.0f;  //Speeds ball up 
            Score = Score + 50; 
            
        }
        if (col.transform.CompareTag("Trigger"))
        {
            ContactPoint2D cont = col.contacts[0];
            Ball.velocity = Vector2.Reflect(old, cont.normal); //Vector 2 reflects back to the normal
            Ball.velocity += cont.normal * 3.0f;  //Speeds ball up 
            Score = Score + 50;
            
        }

        if (col.transform.CompareTag("Black Bumper"))
        {
            ContactPoint2D cont = col.contacts[0];
            Ball.velocity = Vector2.Reflect(old, cont.normal); //Vector 2 reflects back to the normal
            Ball.velocity += cont.normal * 3.0f;  //Speeds ball up 
            Score = Score + 100;
            
        }
        if (col.transform.CompareTag("White Bumper"))
        {
            ContactPoint2D cont = col.contacts[0];
            Ball.velocity = Vector2.Reflect(old, cont.normal); //Vector 2 reflects back to the normal
            Ball.velocity += cont.normal * 3.0f;  //Speeds ball up 
            Score = Score + 200;
            
        }

        //Out of Bounds to reset ball to original position
        if (col.transform.CompareTag("Out Of Bounds"))
        {
            Balls = Balls - 1; //A ball is taken away and is displayed
            SetBallsText();
        }
    }
    void SetScoreText()
    {
        ScoreText.text = "SCORE: " + Score.ToString();
    }

    void SetBallsText()
    {
        BallsText.text = "Balls Left: " + Balls.ToString();
    }
}
