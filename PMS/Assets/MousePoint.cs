using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MousePoint : MonoBehaviour
{
    public Camera camera;
    public Vector2 mouseWorldPos;
    public Vector2 mouseWorldPosUnit;
    public float angleVal;

    public bool canShoot = true;


    private Transform ball;
    private Vector2 ballPos;



   // Start is called before the first frame update
    void Start()
    {
        
        ball = GetComponent<Transform>();

        
    }



   // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButtonDown(0) && canShoot){
            //canShoot= false;
            ballPos = transform.position;

            //takes mouse coordinates from the screen into world coordinates
            mouseWorldPos = camera.ScreenToWorldPoint(Input.mousePosition);
            //creates vector with ball as the origin, vector from mouse to the ball
            mouseWorldPosUnit = (mouseWorldPos - ballPos).normalized; //normalized  makes it unit vector
            //finds angle in radians from arctan, converts to degrees
            angleVal = (180 / Mathf.PI) * Mathf.Atan(mouseWorldPosUnit.y / mouseWorldPosUnit.x);
        }
    }
}