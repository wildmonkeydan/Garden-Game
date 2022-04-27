using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class InventorySlot
{
    [SerializeField] private InventoryData itemData;
    [SerializeField] private int stackSize;

    public InventoryData ItemData => itemData;
    public int StackSize => stackSize;
    public InventorySlot(InventoryData source, int amount)
    {
        itemData = source;
        stackSize = amount;
    }

    public InventorySlot()
    {
        ClearSlot();
    }

    public void ClearSlot()

    {
        itemData = null;
        stackSize = -1;
    }

    public void UpdateInventorySlot(InventoryData data,int size)
    {
        itemData = data;
        stackSize = size;
    }
    public bool RoomLeftInStack(int amountToAdd, out int amountRemaining)
    {

        amountRemaining = ItemData.MaxStackSize - stackSize;

        return RoomLeftInStackE(amountToAdd);

    }



    public bool RoomLeftInStackE(int amountToAdd)
    {
        if (stackSize + amountToAdd <= itemData.MaxStackSize) return true;
        else return false;
    }

    public void AddToStack(int amount)
    {
        stackSize += amount;
    }

    public void RemoveFromStack(int amount)
    {
        stackSize -= amount;
    }

    
}


