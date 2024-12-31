using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeighttText : MonoBehaviour
{
    private GameObject heightbody;
    public BlockHeight ballHeight; //Changed to public Beza
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        heightbody = GameObject.Find("HeightBody");
        ballHeight= heightbody.GetComponent<BlockHeight>();
        text = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Initial Height: " + ((float)ballHeight.self.position.y) + "m"; // added 6/2 because I made the height of the block 6 in the Y direction. 
    }
} 