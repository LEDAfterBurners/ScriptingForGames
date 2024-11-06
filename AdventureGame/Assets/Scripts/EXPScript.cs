using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXPScript : MonoBehaviour
{
    public float expData;
    public int Level;

    public void ChangeEXP(float amount)
    {
        if (expData < 1)
        {
            expData += 1/Level;
        }
        else
        {
            expData = 0;
            Level += 1;
        }
    }
    /**
    public SimpleFloatData expData;
    public SimpleIntData Level;

    public void ChangeEXP(float amount)
    {
        if (expData < (float)1)
        {
            expData.UpdateValue(1/Level);
        }
        else
        {
            expData.SetValue(0);
            Level.UpdateValue(1);
        }

    }
    **/
}
    