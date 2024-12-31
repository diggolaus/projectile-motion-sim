using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
//input.mouseposition, screen coordinates
//camera.ScreenToWorldPoint, converts screen coords to world coords
//text input. Scroll input is better: mouseScrollDelta. 
//Input.GetMouseButtonDown() for clicking, says which button is being pressed
//calculate the arc and draw it (w/ box sprites?)

//for angle: take the world coords of mouse, vector.normalized and v = u.Normalize() =unit vector,
// force * unit vector to take magnitude of force and point it in direction of mouse
//brackeys good tutorials

//input: HEIGHT (transform z val of rectangle), MASS (change rigidbody mass), ANGLE (get mouse pos unit vector), VELOCITY ( velocity :) )
//output: TRAJECTORY-TIME (equation/timer?), RANGE (equation?), MAX-HEIGHT (equation?)
/// <summary>
/// to do:    v slider inputs for angle and x and z coords of velocity
///           x draw a line path  -- prefabs
///           x draw impact location
///           v Can mass of object be changed via user input?
///           
///           v Can a rectangle be transformed via user input?
///           v  print time, range, and height
///           v be able to start and stop the simulation
///           x draw an arrow representing velocity
///             
///       change x velocity: arrow keys right left
///       change z velocity: arrow keys up down
///       change angle: w up, s down
///       change mass: z up, x down
/// </summary>
/// 

public class projectile : MonoBehaviour
{
    public bool canShoot = true;
    public float Force = 1000f;
    public float x_velocity = 5f;
    public float z_velocity = 0f;
    public Transform ball;
    public Rigidbody2D rb;

    private float forceIncrement = 5f;
    private float massIncrement = 0.5f;
    private float xvIncrement = 1f;
    private float zvIncrement = 1f; 

    public Vector2 shoot_direction; //changed this to public (Beza)
    public MousePoint mousePoint;

   // private Vector3 endPosition; // Added this for the ball to stop.
    //private float movementSpeed = 3f; 
    //RectTransform rT;

    // Start is called before the first frame update
    void Start()
    {
        mousePoint = GetComponent<MousePoint>();
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //x_velocity += input.mouseWheelDelta;
        //y_velocity += input.mouseWheelDelta;
        //mass
        
      //  if ( Input.GetMouseButtonDown(0) && canShoot)
        if ( Input.GetKeyDown(KeyCode.Return) && canShoot)

        {
            canShoot= false;
            rb.AddForce(shoot_direction);
        }

        if ( Input.GetKeyDown(KeyCode.UpArrow))
        {
            Force += forceIncrement;
        }
        //Added this part to allow decrease in force 
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Force -= forceIncrement;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.mass += 1;
        }
        //Added this part to allow decrease in mass 
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.mass -= 1;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            ball.position = new Vector3(-8.8f, 15f, 0f);
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f;
            canShoot = true;
        }

        //Debug.Log(rb.velocity.y);
       // Debug.Log(ball.position);
    }
    
    void FixedUpdate()
    { 
        shoot_direction = new Vector2(mousePoint.mouseWorldPosUnit.x * Force, mousePoint.mouseWorldPosUnit.y * Force);
        
        }
    
    public double  getTime(float z_velocity, float launch_height) 
    {
        float v = z_velocity;
        float h = launch_height;
        return (((-v) - Mathf.Sqrt((v*v) + 2f*(9.8f)*h)) / (-9.8f));
    }
    
    public double getRange(float x_velocity, float time) 
    {
        float v = x_velocity;
        float t = time;
        return v * t;
    }

    //public double getHeight(float z_velocity, float time, float launch_height) 
    public double getHeight(float time) 

    {
        float t = time;
        Debug.Log(-(-9.81)*(t*t)/2);
        return -(-9.81)*(t*t)/2;
    }
    void DrawTrajectory() {
        
    }
    void ChangeHeight() { }
    void RunSim() { }
}



//movementSpeed = ((Force/rb.mass) * Time.fixedDeltaTime);
 //       endPosition = new Vector3(10, 3, 0);

  ///      if (transform.position == endPosition ){
            
  //          rb.velocity = Vector3.zero;
            //rb.angularVelocity = Vector3.zero;