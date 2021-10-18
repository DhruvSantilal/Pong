using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //speed of the enemy
    public float speed = 1.75F;

    //the ball
    Transform ball;

    //the balls rigidbody 2D
    Rigidbody2D ballRig2D;

    //bounds of enemy
    public float topBound = 4.5f;
    public float bottomBound = -4.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //finding the ball
        if(ball == null){
            ball = GameObject.FindGameObjectWithTag("Ball").transform;
        }

        //setting the balls rigidbody to a varibale
        ballRig2D = ball.GetComponent<Rigidbody2D>();

        //checking x direction of the blal
        if(ballRig2D.velocity.x < 0){
            //chcking y direction of ball
            if(ball.position.y < this.transform.position.y){
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            else if (ball.position.y > this.transform.position.y){
                //move balls up if higher than paddle
                transform.Translate(Vector3.up *speed* Time.deltaTime);
            }
        }

        //set bounds of enemy
        if(transform.position.y > topBound){
            transform.position = new Vector3(transform.position.x, topBound, 0);

        }
        else if(transform.position.y < bottomBound){
            transform.position = new Vector3(transform.position.x, bottomBound, 0);
        }
    }
}
