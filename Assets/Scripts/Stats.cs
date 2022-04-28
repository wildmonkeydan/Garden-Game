using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public float health = 100f;
    public float airQuality = 100f;
    public void healthUpdate(float healthChange)
    {
        health += healthChange;
        if(health > 100)
        {
            health = 100;
        }
    }
    public void airUpdate(float airChange)
    {
        airQuality += airChange;
        if (airQuality > 100)
        {
            airQuality = 100;
        }
    }
}
