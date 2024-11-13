using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXPScript : MonoBehaviour
{
    public SimpleFloatData expData;
    public SimpleFloatData level;
    private float expDataTemp;
    private float levelTemp = 1.0f;

    public void ChangeEXP(float amount)
    {
        if (expDataTemp < 1.0f)
        {
            expDataTemp += 1.0f/(levelTemp + 2);
        }
        else
        {
            expDataTemp = 0.0f;
            levelTemp += 1.0f;
        }
        expData.SetValue(expDataTemp);
        level.SetValue(levelTemp);
    }
    /**
    public SimpleFloatData expData;
    public SimpleIntData Level;
    public float 

    public void ChangeEXP(float amount)
    {
        if (expData < One)
        {
            expData.UpdateValue(One/Level);
        }
        else
        {
            expData.SetValue(0);
            Level.UpdateValue(1);
        }
    }
    **/
}
    