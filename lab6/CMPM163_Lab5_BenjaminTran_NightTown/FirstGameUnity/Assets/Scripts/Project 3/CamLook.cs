//Used Jimmy Vegas's tutorial video on how to make a static camera follow player: https://www.youtube.com/watch?v=PXJJ7SE3RXQ

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamLook : MonoBehaviour
{
	public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	transform.LookAt(Player.transform);   
    }
}
