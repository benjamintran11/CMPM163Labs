using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSwitch : MonoBehaviour
{
	public Camera R1; //room 1
	public Camera R2; //room 2
	public Camera R3; //room 3

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit) 
    {
    	if (hit.gameObject.name == "First Room")
    	{
    		DisableCameras();
    		R1.enabled = true;
    		R2.enabled = false;
    		R3.enabled = false;
    	}
    	else if (hit.gameObject.name == "Second Room")
    	{
    		DisableCameras();
    		R1.enabled = false;
    		R2.enabled = true;
    		R3.enabled = false;
    	}
    	else if (hit.gameObject.name == "Third Room")
    	{
    		DisableCameras();
    		R1.enabled = false;
    		R2.enabled = false;
    		R3.enabled = true;
    	}
    }

    public void DisableCameras()
    {
    	R1.enabled = false;
    	R2.enabled = false;
    	R3.enabled = false;
    }
}
