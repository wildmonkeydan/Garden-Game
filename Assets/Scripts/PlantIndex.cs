using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantIndex : MonoBehaviour
{
    public GameObject[] obj;
    public class Plant
    {
        public GameObject obj;
        public float growthTime;
        public float nutrition;
        public float airQuality;

        public Plant(GameObject obj, float growthTime, float nutrition, float airQuality)
        {
            this.obj = obj;
            this.growthTime = growthTime;
            this.nutrition = nutrition;
            this.airQuality = airQuality;
        }

    }

    public Plant potato;
    public Plant carrot;
    public Plant strawberry;
    public Plant blackberry;
    void Start()
    {
        potato = new Plant(obj[0], 45, 30f, 10f);
        carrot = new Plant(obj[1], 30f, 20f, 20f);
        strawberry = new Plant(obj[2], 60f, 25f, 40f);
        blackberry = new Plant(obj[3], 90f, 50f, 30f);
    }
}
