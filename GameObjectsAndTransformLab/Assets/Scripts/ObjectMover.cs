using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;

    void Update()
    {
        // move the object back and forth on the x-axis
        float x = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
