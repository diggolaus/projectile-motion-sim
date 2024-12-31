using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangeText : MonoBehaviour
{
    private GameObject ball;
    private projectile ballProj;
    private Text text;

    private GameObject heightbody;
    public BlockHeight ballHeight;
    //private HeighttText height; 

    private MousePoint ballAngle; // had to add this as well
    
    public float V = 4f;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
        ballProj = ball.GetComponent<projectile>();

        ballAngle = ball.GetComponent<MousePoint>();

        text = GetComponent<Text>();
        
        heightbody = GameObject.Find("HeightBody");
        ballHeight= heightbody.GetComponent<BlockHeight>();
        V = (float)((ballProj.Force/ballProj.rb.mass) * Time.fixedDeltaTime);

        //ballHeight= heightbody.GetComponent<BlockHeight>();
        
    }   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
        text.text = "Range: " + Mathf.Round((float)ballProj.getRange(V*Mathf.Cos(Mathf.Deg2Rad * ballAngle.angleVal), (float)ballProj.getTime(20, ballHeight.self.position.y))*100f) * 0.01f + "m"; 
        //text.text = "Range: " + (float)ballProj.getRange(30, ((-25f + Mathf.Sqrt((25f*25f) + 2f*(9.8f)*ballHeight.self.position.y) / (-9.8f))));
        }
    }
}

//(float)((ballProj.Force/ballProj.rb.mass) * Time.fixedDeltaTime) = velocity
// Vx = Vcos(angle)
// angle =  Mathf.Round(ballAngle.angleVal
// ballAngle = ball.GetComponent<MousePoint>() --- need to add this in Void Start()

