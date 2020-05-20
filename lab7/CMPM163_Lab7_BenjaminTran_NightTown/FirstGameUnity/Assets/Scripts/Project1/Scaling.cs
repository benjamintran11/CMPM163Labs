using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
	public float x = 0.1f;
	public float y = 0.1f;
	public float z = 0.1f;
	Vector3 a;
    
    // Start is called before the first frame update
    void Start()
    {

       // a = transform.localScale; //sets vector3 a variable to new scale
    }

    // Update is called once per frame
    void Update()
    {
    	a = transform.localScale;
    }

    public void Scale() {
    	a.x += x;
    	a.y += y;
    	a.z += z; 
    	transform.localScale = a;
	}
}
