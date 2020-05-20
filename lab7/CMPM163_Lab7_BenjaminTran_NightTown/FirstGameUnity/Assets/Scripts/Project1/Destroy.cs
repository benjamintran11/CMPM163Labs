//https://www.youtube.com/watch?v=NQT6tfPIL3s

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    //[SerializeField]
    public GameObject Cube;

    public void DestroyGameObject() 
    {
    	Destroy(Cube);
    }
}
