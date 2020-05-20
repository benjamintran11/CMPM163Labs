//used Lurony's video on Triggers as reference: https://www.youtube.com/watch?v=tCe_UfyirT4
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRooms : MonoBehaviour
{
	public GameObject camera1;
	public GameObject camera2; 
	public GameObject camera3;
	public bool camera1check;
	public bool camera2check;
	public bool camera3check;

    // Start is called before the first frame update
    void Start()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera1check = true;
        camera2check = false;
        camera3check = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick() {
    	//room 1 (main part of town)
    	if (camera1check == true)
    	{
    	camera1.SetActive(false);
    	camera2.SetActive(true);
    	camera1check = false;
    	camera2check = true;
    	Debug.Log("hit");
    	}
    	//monument area
    	else if (camera2check == true)
    	{
    	camera2.SetActive(false);
    	camera3.SetActive(true);
    	camera2check = false;
    	camera3check = true;
    	Debug.Log("hit1");
    	}
    	//mansion (lone house)
       else if (camera3check == true)
    	{
    	camera3.SetActive(false);
    	camera1.SetActive(true);
    	camera3check = false;
    	camera1check = true;
    	Debug.Log("hit1");
    	}
  	}
}
