using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    //speed of the ball
    public float speed = 3.5f;

    //the initial direction of the ball
    private Vector2 spawnDir;

    //balls components
    Rigidbody2D rig2D;

    // Start is called before the first frame update
    void Start()
    {
        //setting balls rigidbody 2d
        rig2D = this.gameObject.GetComponent<Rigidbody2D>();

        //generating random number based on possible initial directions
        int rand = Random.Range(1, 4);

        //setting initla direction 
        if(rand ==1){
            spawnDir = new Vector2(1,1);
        }
        else if(rand == 2){
            spawnDir = new Vector2(1, -1);
        }
        else if (rand == 3){
            spawnDir = new Vector2(-1,-1);
        }
        else if(rand == 4){
            spawnDir = new Vector2(-1, 1);
        }

        //moving ball in initial direction and adding speed
        rig2D.velocity = (spawnDir * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
