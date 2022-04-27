using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpStuff : MonoBehaviour
{
    //public Transform hands;
    public Camera cam;
    public InventoryHolder inventoryHolder;
    public InventoryData wateringCanData;
    public WateringCan can;
    

    /*private void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = hands.position;
        this.transform.parent = GameObject.Find("Player").transform;
    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
    }*/

    private void Start()
    {

    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = new Ray(transform.position, cam.transform.forward);
            Physics.Raycast(ray, out RaycastHit hit);
            if(hit.collider.gameObject.tag == "canpickup")
            {
                Destroy(hit.collider.gameObject);
                inventoryHolder.InventorySystem.AddToInventory(wateringCanData, 1);
            }
            if (hit.collider.gameObject.tag == "h2o")
            {
                can.waterLevel = 0.01f;
            }
        }
    }
}
