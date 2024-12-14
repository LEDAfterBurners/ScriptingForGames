using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public SimpleFloatData healthData;

    public void Start()
    {
        healthData.SetValue(1.0f);
    }

    public void ChangeHealth(float amount)
    {
        healthData.UpdateValue(amount);
    }
}
