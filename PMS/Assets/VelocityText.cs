using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VelocityText : MonoBehaviour
{
    private GameObject ball;
    private projectile ballProj;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
        ballProj = ball.GetComponent<projectile>();

        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Launch Velocity: " + Mathf.Round((float)((ballProj.Force/ballProj.rb.mass) * Time.fixedDeltaTime)*100f) * 0.01f + "m/s";
        
    }
}
