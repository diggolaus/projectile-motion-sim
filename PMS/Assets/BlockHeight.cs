using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHeight : MonoBehaviour
{

    public Transform self; //changed to public Beza

    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)){
            float z = 0;
            float x = self.position.x;
            float y = self.position.y - 1;
            self.position = new Vector3(x, y, z);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            float z = 0;
            float x = self.position.x;
            float y = self.position.y + 1;
            self.position = new Vector3(x, y, z);
        }
    }
}
