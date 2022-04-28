using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpStuff : MonoBehaviour
{
    //public Transform hands;
    public Camera cam;
    public InventoryHolder inventoryHolder;
    public InventoryData wateringCanData;
    public InventoryData shovelData;
    public InventoryData potato;
    public GameObject potatoObj;
    public WateringCan can;
    public InventoryEquip equip;
    public Text text;
    string hint = "";
    bool canPlace = true;

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
        Ray ray = new Ray(transform.position, cam.transform.forward);
        Physics.Raycast(ray, out RaycastHit hit);

        hint = " ";

        if (hit.collider.gameObject.tag == "canpickup")
        {
            hint = "Pick Up Watering Can";
        }

        if (hit.collider.gameObject.tag == "h2o")
        {
            hint = "Refill Watering Can";
        }

        if(hit.collider.gameObject.tag == "shovelpickup")
        {
            hint = "Pick Up Shovel";
        }

        if (Input.GetMouseButton(0))
        {
            
            if(hit.collider.gameObject.tag == "canpickup")
            {
                Destroy(hit.collider.gameObject);
                inventoryHolder.InventorySystem.AddToInventory(wateringCanData, 1);
            }
            if (hit.collider.gameObject.tag == "h2o")
            {
                can.waterLevel = 0.01f;
            }
            if (hit.collider.gameObject.tag == "shovelpickup")
            {
                Destroy(hit.collider.gameObject);
                inventoryHolder.InventorySystem.AddToInventory(shovelData, 1);
            }
            if(hit.collider.gameObject.tag == "soil")
            {
                inventoryHolder.InventorySystem.AddToInventory(potato, 1);
            }
            if(hit.collider.gameObject.tag == "potato")
            {
                Destroy(hit.collider.gameObject);
                inventoryHolder.InventorySystem.AddToInventory(potato, 1);
            }
        }

        if (Input.GetMouseButton(1))
        {
            if (hit.collider.gameObject.tag == "soil" && inventoryHolder.InventorySystem.InventorySlots[equip.index].StackSize > 0 && canPlace)
            {
                GameObject potatoInstance = Instantiate(potatoObj,hit.point,Quaternion.identity);
                inventoryHolder.InventorySystem.InventorySlots[equip.index].RemoveFromStack(1);
                canPlace = false;
                Invoke("wait", 0.4f);
            }
        }

        text.text = hint;
    }

    void wait()
    {
        canPlace = true;
    }
}
