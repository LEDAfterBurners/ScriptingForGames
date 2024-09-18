using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
