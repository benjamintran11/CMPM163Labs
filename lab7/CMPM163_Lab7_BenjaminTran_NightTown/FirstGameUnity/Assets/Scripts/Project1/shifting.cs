using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shifting : MonoBehaviour
{
	//public float move = .01f;
	Vector3 a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	a = transform.position;
      	a.x += .08f;
      	//Debug.Log(move); 
      	transform.position = a;  
      	//Debug.Log(a.x); 
    }
}
