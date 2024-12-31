using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    private GameObject ball;
    private projectile ballProj;
    private Text text;

    private GameObject heightbody;
    public BlockHeight ballHeight;
    //private HeighttText height; 

    private MousePoint ballAngle; // had to add this as well
    
    public float V = 4f;


    void Start()
    {
      ball = GameObject.Find("Ball");
      ballProj = ball.GetComponent<projectile>();

      ballAngle = ball.GetComponent<MousePoint>();

      text = GetComponent<Text>();

      heightbody = GameObject.Find("HeightBody");
      ballHeight= heightbody.GetComponent<BlockHeight>();

      V = (float)((ballProj.Force/ballProj.rb.mass) * Time.fixedDeltaTime);
    }
        
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.T)){
      text.text = "Trjactory time: " + Mathf.Round((float)ballProj.getTime(V*Mathf.Sin(ballAngle.angleVal * Mathf.Deg2Rad), ballHeight.self.position.y)*100f)* 0.01f + "s";//(float)ballHeight.self.position.y);
      }
    }
}
