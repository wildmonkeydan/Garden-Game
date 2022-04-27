using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCan : MonoBehaviour
{
    public ParticleSystem water;
    public GameObject container;
    Material waterMaterial;
    bool toggle;
    bool canToggle = true;
    public float waterLevel = 0;
    // Start is called before the first frame update
    void Start()
    {
        water.gameObject.SetActive(false);
        waterMaterial = container.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && canToggle)
        {
            toggle = !toggle;
            canToggle = false;
            Invoke("reset", 0.2f);
        }
        if (toggle)
        {
            water.gameObject.SetActive(true);
            waterLevel += 0.0001f;
        }
        else
        {
            water.gameObject.SetActive(false);
        }

        if(waterLevel > 1)
        {
            waterLevel = 1;
        }

        if(waterLevel == 1)
        {
            toggle = false;
        }
        int id = waterMaterial.shader.GetPropertyNameId(2);
        waterMaterial.SetFloat(id, waterLevel);
    }

    void reset()
    {
        canToggle = true;
    }
}
