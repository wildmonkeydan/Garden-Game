using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryEquip : MonoBehaviour
{
    public int index = 0;
    public InventoryHolder inventory;
    public GameObject wateringCan;
    public GameObject shovel;
    public GameObject potato;
    public GameObject carrot;
    public GameObject strawberry;
    public GameObject blackberry;
    public Image[] slots;
    public Material[] materials;
    public Text[] nums;
    public Image highlight;
    void Start()
    {
        wateringCan.SetActive(false);
        shovel.SetActive(false);
        potato.SetActive(false);
        carrot.SetActive(false);
        strawberry.SetActive(false);
        blackberry.SetActive(false);
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
                blackberry.SetActive(false);
            }
            if(inventory.InventorySystem.InventorySlots[index].ItemData.ID == 1)
            {
                wateringCan.SetActive(false);
                shovel.SetActive(true);
                potato.SetActive(false);
                carrot.SetActive(false);
                strawberry.SetActive(false);
                blackberry.SetActive(false);
            }
            if(inventory.InventorySystem.InventorySlots[index].ItemData.ID == 2)
            {
                wateringCan.SetActive(false);
                shovel.SetActive(false);
                potato.SetActive(true);
                carrot.SetActive(false);
                strawberry.SetActive(false);
                blackberry.SetActive(false);
            }
            if(inventory.InventorySystem.InventorySlots[index].ItemData.ID == 3)
            {
                wateringCan.SetActive(false);
                shovel.SetActive(false);
                potato.SetActive(false);
                carrot.SetActive(true);
                strawberry.SetActive(false);
                blackberry.SetActive(false);
            }
            if (inventory.InventorySystem.InventorySlots[index].ItemData.ID == 5)
            {
                wateringCan.SetActive(false);
                shovel.SetActive(false);
                potato.SetActive(false);
                carrot.SetActive(false);
                strawberry.SetActive(true);
                blackberry.SetActive(false);
            }
            if (inventory.InventorySystem.InventorySlots[index].ItemData.ID == 4)
            {
                wateringCan.SetActive(false);
                shovel.SetActive(false);
                potato.SetActive(false);
                carrot.SetActive(false);
                strawberry.SetActive(false);
                blackberry.SetActive(true);
            }
        }
        else
        {
            wateringCan.SetActive(false);
        }
        for (int i = 0; i < 10; i++)
        {
            slots[i].material = materials[inventory.InventorySystem.InventorySlots[i].ItemData.ID];
            nums[i].text = string.Format("{0}",inventory.InventorySystem.InventorySlots[i].StackSize);
        }
        highlight.rectTransform.anchoredPosition = new Vector3((index * 6.9f) - 30.83f, -43.77f, 0);
    }
}
