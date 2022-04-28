using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    public float health = 100f;
    public float airQuality = 100f;
    public Text healthT;
    public Text airQualityT;
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

    private void Update()
    {
        health -= 0.001f;
        airQuality -= 0.001f;
        healthT.text = string.Format("{0}",health);
        airQualityT.text = string.Format("{0}",airQuality);

        if(health < 0)
        {
            SceneManager.LoadScene("samplescene");
        }
        if (airQuality < 0)
        {
            SceneManager.LoadScene("samplescene");
        }
    }
}
