
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AngleText : MonoBehaviour

{

    private GameObject ball;

    private MousePoint ballAngle;

    private Text text;

    // Start is called before the first frame update

    void Start()

    {

        //ball = GameObject.Find("Ball");
        
        ball = GameObject.Find("Ball");

        ballAngle = ball.GetComponent<MousePoint>();

        //ballProj = ball.GetComponent<MousePoint>();

        //mouseWorldPos = mousePoint.GetComponent<;


        text = GetComponent<Text>();

    }


    // Update is called once per frame

    void Update()

    {        
    //Debug.Log(ballAngle.mouseWorldPosUnit);        
    text.text = "Angle: " + Mathf.Round(ballAngle.angleVal) + "°";

    }

}

