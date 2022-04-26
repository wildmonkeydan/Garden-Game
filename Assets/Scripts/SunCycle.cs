using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 angle = gameObject.transform.eulerAngles;
        gameObject.transform.eulerAngles = new Vector3(angle.x + 0.001f, angle.y, angle.z);
    }
}
