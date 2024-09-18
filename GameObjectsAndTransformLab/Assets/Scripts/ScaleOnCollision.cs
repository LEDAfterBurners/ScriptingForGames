using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOnCollision : MonoBehaviour
{
    public float shrinkFactor = 1.01f;

    void OnCollisionEnter(Collision collision)
    {
        transform.localScale *= shrinkFactor;
    }
}
