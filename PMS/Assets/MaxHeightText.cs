using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxHeightText : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject ball;
    private projectile ballProj;

    //projectile projectileScript;
    private Text text;
    
    private GameObject heightbody;
    public BlockHeight ballHeight;

    private MousePoint ballAngle; // had to add this as well
    public float V = 4f; 

    void Start()
    {
      //projectileScript = FindObjectOfType<projectile>();
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
      if (Input.GetKeyDown(KeyCode.H)){
      text.text = "Max Height: " + Mathf.Round((float)ballProj.getHeight((float)ballProj.getTime(V*Mathf.Sin(ballAngle.angleVal * Mathf.Deg2Rad), ballHeight.self.position.y))*100.0f) * 0.01f + "m";
      }
    }
}
// ballHeight.self.position.y()
//
// for getTime() we need Vz 
// Vz = Vsin(angle)
// angle =  ballAngle.angleVal to convert to radians 
// angle = ballAngle.angleVal * Mathf.Deg2Rad
// V = (float)((ballProj.Force/ballProj.rb.mass) * Time.fixedDeltaTime)
//ballAngle = ball.GetComponent<MousePoint>() --- need to add this in Void Start()