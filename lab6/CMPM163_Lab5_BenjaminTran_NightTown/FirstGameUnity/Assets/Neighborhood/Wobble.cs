using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobble : MonoBehaviour
{
    public float maxOffset = 0.4f;
    public float speed = 0.1f;

    public AnimationCurve eastInEastOut;
    private float baseHeight;
    private float timeOffset;

    private void Awake()
    {
        baseHeight = transform.position.y - maxOffset;
        speed += Random.Range(0.0f, speed*0.2f);
        timeOffset = Random.Range(0.0f, 10.0f);
    }

    private void Update()
    {
        float t = eastInEastOut.Evaluate( Mathf.PingPong(Time.time*speed + timeOffset, 1.0f));
        float yPos = baseHeight + t * maxOffset * 2;

        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
}
