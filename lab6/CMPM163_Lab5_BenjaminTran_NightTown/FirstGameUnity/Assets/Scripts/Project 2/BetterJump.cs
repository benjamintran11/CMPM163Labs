//referenced using Board To Bits Games's video on Jumping: https://www.youtube.com/watch?v=7KiK0Aqtmzc


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour
{
    //values for gravity, determines accerlation when falling and limits how high character jumps
	public float fallMultiplier = 2.5f;
	public float lowJumpMultiplier = 2f;

	Rigidbody rb;

	void Awake() {
		rb = GetComponent<Rigidbody> ();
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks to see if character is falling
        if (rb.velocity.y < 0) {
        	rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime; //jump
        } 
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump")) {
        	rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime; //fall
        }
    }
}
