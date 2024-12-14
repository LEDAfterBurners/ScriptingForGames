using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public SimpleIntData scoreData;

    public void Start()
    {
        scoreData.SetValue(0);
    }
    public void ChangeScore(int amount)
    {
        scoreData.UpdateValue(amount);
    }
}
