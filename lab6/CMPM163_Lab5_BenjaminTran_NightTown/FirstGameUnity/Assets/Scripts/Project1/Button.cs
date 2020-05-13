using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
	public MeshRenderer mesh;

	public void ColorChange() {
		var color = this.mesh.material.color; //color grabs current color object and stores it in color.
		//this.mesh.material.color = new Color(Random.Range(0,1), Random.Range(0,1), Random.Range(0,1));
		Debug.Log("hit");
		color.r = Random.Range(0f,1f);
		color.g = Random.Range(0f,1f);
		color.b = Random.Range(0f,1f);

		this.mesh.material.color = color;


	} 
    // Start is called before the first frame update
    void Start()
    {
        this.mesh = this.GetComponent<MeshRenderer>();
        //meshRenderer.material.color = new Color(1.0f, 1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
