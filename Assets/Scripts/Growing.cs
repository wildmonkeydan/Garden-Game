using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growing : MonoBehaviour
{
    public PlantIndex index;
    public PlantIndex.Plant current;
    public int id;
    public bool isGrown = false;
    public Stats stats;
    bool watered = false;
    float scaleFactor;
    GameObject seedling;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Grow()
    {
        watered = true;
        switch (id)
        {
            case 0:
                current = index.potato;
                break;
            case 1:
                current = index.carrot;
                break;
            case 2:
                current = index.strawberry;
                break;
            case 3:
                current = index.blackberry;
                break;
        }
        seedling = Instantiate(current.obj,transform.localPosition,transform.localRotation);
        seedling.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        scaleFactor = 0.99f / current.growthTime;
        Debug.Log(scaleFactor);
        InvokeRepeating("Scale", 1f, 1f);
        Invoke("Grown", current.growthTime);
        if(id == 1)
        {
            MeshFilter meah = GetComponent<MeshFilter>();
            meah.mesh = null;
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        if (watered == false)
        {
            Grow();
        }
    }

    void Grown()
    {
        CancelInvoke("Scale");
        stats.airUpdate(current.airQuality);
        isGrown = true;
    }

    void Scale()
    {
        seedling.transform.localScale += new Vector3(scaleFactor,scaleFactor,scaleFactor);
        Debug.Log("Grow");
    }
}
