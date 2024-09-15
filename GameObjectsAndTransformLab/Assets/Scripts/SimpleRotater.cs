using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotater : MonoBehaviour
{
    public float rotationSpeed = 100f;
    
    void Update()
    {
        // rotate object around the y-axis
        transform.Rotate(0, Time.time * rotationSpeed, 0);
    }
}
