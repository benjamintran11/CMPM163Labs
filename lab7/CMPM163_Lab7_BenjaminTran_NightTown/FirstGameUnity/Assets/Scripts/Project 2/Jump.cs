//referenced using Board To Bits Games's video on Jumping: https://www.youtube.com/watch?v=7KiK0Aqtmzc

using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	[Range(1, 10)]
	public float jumpVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	//checks if pressing Jump
        if (Input.GetKeyDown("space")) {
        	//Rigid body's velocity equals vector upward motion value times jump velocity 
        	GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
        }
    }
}
