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
        itemData = null;
        stackSize = -1;
        {
            ClearSlot();
        }

        void ClearSlot()

        {
            itemData = null;
            stackSize = -1;
        }

        {
           bool RoomLeftInStack(int amountToAdd, out int amountRemaining);

            amountRemaining = ItemData.MaxStackSize - stackSize;

            return RoomLeftInStack(amountToAdd);



            bool RoomLeftInStack(int amountToAdd)
            {
                if (stackSize + amountToAdd <= itemData.MaxStackSize) return true;
                else return false;
            }

            void AddToStack(int amount)
            {
                stackSize += amount;
            }

            void RemoveFromStack(int amount)
            {
                stackSize -= amount;
            }
        }
    }
}



