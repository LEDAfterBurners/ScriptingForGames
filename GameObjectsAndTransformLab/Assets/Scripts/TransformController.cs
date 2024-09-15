using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    public void Update()
    {
        // Move the target GameObject
        int radius = 1;
        int degrees = 1;
        double circlePosX = Math.Cos(degrees) * radius;
        double circlePosY = Math.Sin(degrees) * radius;
        var p = new Vector3(Time.time*(float)circlePosX,Time.time*(float)circlePosY, 0);
        transform.Translate(p);
        
        /*
        
        
        var x = Mathf.PingPong(Time.time,6);
        var y = Mathf.PingPong(Time.time,1);
        var p = new Vector3(x,Math.Cos((float)y),0);
        transform.position = p;
        */
        
        // Rotate the target GameObject
        transform.Rotate(new Vector3(360,0,0)*Time.deltaTime);
    }
}
