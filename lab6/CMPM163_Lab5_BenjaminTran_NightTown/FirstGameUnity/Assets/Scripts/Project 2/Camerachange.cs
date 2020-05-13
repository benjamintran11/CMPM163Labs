using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerachange : MonoBehaviour
{
	public GameObject camera1;
	public GameObject camera3;
	public bool camera1check;
	public bool camera3check;

    // Start is called before the first frame update
    void Start()
    {
        camera1.SetActive(false);
        camera3.SetActive(true);
        camera1check = false;
        camera3check = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick() {
    	if (camera1check == true)
    	{
    	camera1.SetActive(false);
    	camera3.SetActive(true);
    	camera1check = false;
    	camera3check = true;
    	Debug.Log("hit");
    	}
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
