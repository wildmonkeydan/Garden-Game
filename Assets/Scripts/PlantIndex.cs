using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantIndex : MonoBehaviour
{
    public Mesh[] meshes;
    public Material[] materials;
    public class Plant
    {
        public Mesh mesh;
        public Material material;
        public float growthTime;
        public float nutrition;
        public float airQuality;

        public Plant(Mesh mesh, Material material, float growthTime, float nutrition, float airQuality)
        {
            this.mesh = mesh;
            this.material = material;
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
        potato = new Plant(meshes[0], materials[0], 45f, 30f, 10f);
        carrot = new Plant(meshes[1], materials[1], 30f, 20f, 20f);
        strawberry = new Plant(meshes[2], materials[2], 60f, 25f, 40f);
        blackberry = new Plant(meshes[3], materials[3], 90f, 50f, 30f);
    }
}
