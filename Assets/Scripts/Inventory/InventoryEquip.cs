using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryEquip : MonoBehaviour
{
    public int index = 0;
    public InventoryHolder inventory;
    public GameObject wateringCan;
    public GameObject shovel;
    public GameObject potato;
    public GameObject carrot;
    public GameObject strawberry;
    void Start()
    {
        wateringCan.SetActive(false);
        shovel.SetActive(false);
        potato.SetActive(false);
        carrot.SetActive(false);
        strawberry.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        index += (int)Input.mouseScrollDelta.y;
        if(index == -1)
        {
            index = 0;
        }
        if(index == 10)
        {
            index = 9;
        }
        if (inventory.InventorySystem.InventorySlots[index].StackSize != -1)
        {
            if (inventory.InventorySystem.InventorySlots[index].ItemData.ID == 0)
            {
                wateringCan.SetActive(true);
                shovel.SetActive(false);
                potato.SetActive(false);
                carrot.SetActive(false);
                strawberry.SetActive(false);
            }
            if(inventory.InventorySystem.InventorySlots[index].ItemData.ID == 1)
            {
                wateringCan.SetActive(false);
                shovel.SetActive(true);
                potato.SetActive(false);
                carrot.SetActive(false);
                strawberry.SetActive(false);
            }
            if(inventory.InventorySystem.InventorySlots[index].ItemData.ID == 2)
            {
                wateringCan.SetActive(false);
                shovel.SetActive(false);
                potato.SetActive(true);
                carrot.SetActive(false);
                strawberry.SetActive(false);
            }
            if(inventory.InventorySystem.InventorySlots[index].ItemData.ID == 3)
            {
                wateringCan.SetActive(false);
                shovel.SetActive(false);
                potato.SetActive(false);
                carrot.SetActive(true);
                strawberry.SetActive(false);
            }
            if (inventory.InventorySystem.InventorySlots[index].ItemData.ID == 5)
            {
                wateringCan.SetActive(false);
                shovel.SetActive(false);
                potato.SetActive(false);
                carrot.SetActive(false);
                strawberry.SetActive(true);
            }
        }
        else
        {
            wateringCan.SetActive(false);
        }
    }
}
