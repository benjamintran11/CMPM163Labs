using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
	public GameObject camera; //text that appears when triggered
	public string levelToLoad; //level to load

    // Start is called before the first frame update
    void Start()
    {
        camera.SetActive(false); //text doesn't show up until in area
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
    	if (other.gameObject.tag == "Player") //checks if player is there
    	{
    		camera.SetActive(true);
    		if (camera.activeInHierarchy == true && Input.GetButtonDown("Use")) //if player presses button and text is active.
    		{
    			//Application.loadLevel(levelToLoad); //loads new level
    		}
    	}
    }

    void OnTriggerExit()
    {
    	camera.SetActive(false); //sets text back to false, hides it.
    }
}
