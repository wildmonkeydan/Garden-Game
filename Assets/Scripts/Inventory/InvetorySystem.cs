using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;

[System.Serializable]
public class InventorySystem
{
    [SerializeField] private List<InventorySlot> inventorySlots;
    public List<InventorySlot> InventorySlots => inventorySlots;
    public int inventorySize => inventorySlots.Count;
    public UnityAction<InventorySlot> OnInventorySlotChanged;

    public InventorySystem(int size)
    {
        inventorySlots = new List<InventorySlot>(size);

        for(int i = 0; i < size; i++)
        {
            inventorySlots.Add(new InventorySlot());
        }
    }

    public bool AddToInventory(InventoryData item, int size)
    {
        if(ContainsItem(item,out List<InventorySlot> slot))
        {
            foreach(var invslot in slot)
            {
                if (invslot.RoomLeftInStackE(size))
                {
                    invslot.AddToStack(size);
                    OnInventorySlotChanged?.Invoke(invslot);
                    return true;
                }
            }
            
        }
        if(HasFreeSlot(out InventorySlot freeSlot))
        {
            freeSlot.UpdateInventorySlot(item,size);
            OnInventorySlotChanged?.Invoke(freeSlot);
            return true;
        }
        return false;
    }

    public bool ContainsItem(InventoryData item, out List<InventorySlot> invSlot)
    {
        invSlot = InventorySlots.Where(i => i.ItemData == item).ToList();
        return invSlot.Count > 1 ? true : false;
    }

    public bool HasFreeSlot(out InventorySlot invSlot)
    {
        invSlot = InventorySlots.FirstOrDefault(i => i.ItemData == null);
        return invSlot == null ? false:true;
    }
}
