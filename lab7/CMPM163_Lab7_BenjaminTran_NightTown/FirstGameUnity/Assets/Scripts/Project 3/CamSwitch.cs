﻿//Used Jimmy Vegas's video on camera switching as reference: https://www.youtube.com/watch?v=wWTOuggRvgc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
	public GameObject cam1;
	public GameObject cam2;
	public GameObject cam3;
	public GameObject cam4;
    public GameObject cam5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //first room camera (town)
        if (Input.GetButtonDown("1Key"))
        {
        	cam1.SetActive(true);
        	cam2.SetActive(false);
        	cam3.SetActive(false);
        	cam4.SetActive(false);
            cam5.SetActive(false);
        }
        //second room camera (with ball)
        if (Input.GetButtonDown("2Key"))
        {
        	cam1.SetActive(false);
        	cam2.SetActive(true);
        	cam3.SetActive(false);
        	cam4.SetActive(false);
            cam5.SetActive(false);
        }
        //third room camera (with house)
        if (Input.GetButtonDown("3Key"))
        {
        	cam1.SetActive(false);
        	cam2.SetActive(false);
        	cam3.SetActive(true);
        	cam4.SetActive(false);
            cam5.SetActive(false);
        }
        //camera follow you on all axis 
        if (Input.GetButtonDown("4Key"))
        {
        	cam1.SetActive(false);
        	cam2.SetActive(false);
        	cam3.SetActive(false);
        	cam4.SetActive(true);
            cam5.SetActive(false);
        }
        //camera following you on one axis
        if (Input.GetButtonDown("5Key"))
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(true);
        }

    }
}