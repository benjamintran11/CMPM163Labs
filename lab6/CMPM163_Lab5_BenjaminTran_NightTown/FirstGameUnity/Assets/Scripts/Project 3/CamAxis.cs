//referenced using Learn Everything Fast's video on Camera using Y Axis: https://www.youtube.com/watch?v=dp3lZUDij6Y
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAxis : MonoBehaviour
{
	GameObject target; //the player (cube)

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
    	Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
    	
    	transform.LookAt(targetPosition);
    }
}
