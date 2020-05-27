using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildCapitola : MonoBehaviour
{
	public GameObject[] buildings;
	public int mapWidth = 2;
	public int mapHeight = 2;
	int buildingFootprint = 3; //multiplier for spacing out our buildings

    // Start is called before the first frame update
    void Start()
    {	
    	float seed = Random.Range(0,100);
        //seed = 34;
        seed = 30;
        
        //if want set seed value
    	Debug.Log(seed);
    	
    	//going through loop and generating a value of PerlinNoise for each point of the width and height.  
        for (int h = 0; h < mapHeight; h++)
        {
        	for (int w = 0; w < mapWidth; w++)
        	{
        		int result = (int) (Mathf.PerlinNoise(w/9.0f + seed,h/9.0f + seed) * 10); //gives Perline noise width and height of our map
        		//multiplying by 10 because PerlinNoise range is from 0-1, so get values btwn 0-10 
        		//dividing by smaller # -> less detail (larger range in PerlinNoiseMap)
        		//dividing by larger # -> more detail (smaller range in PerlinNoiseMap)
        		//by making the values of w and h smaller (inputs to perlin noise), picking up more detail 

        		Vector3 pos = new Vector3(w * buildingFootprint,0,h * buildingFootprint); //where you're placing new buildings
        		if (result < 2) 
        			Instantiate(buildings[0],pos,Quaternion.identity);
        		else if (result < 3)
        			Instantiate(buildings[1],pos,Quaternion.identity);
        		else if (result < 4)
        			Instantiate(buildings[2],pos,Quaternion.identity);
        		else if (result < 5)
        			Instantiate(buildings[3],pos,Quaternion.identity);
        		else if (result < 6)
        			Instantiate(buildings[4],pos,Quaternion.identity);
        		else if (result < 10)
        			Instantiate(buildings[5],pos,Quaternion.identity);
        		//determining what type of building place depending on Perlin Noise value.




        		//int n = Random.Range(0,buildings.Length);
        		//Instantiate(buildings[n],pos,Quaternion.identity);
        	}
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
