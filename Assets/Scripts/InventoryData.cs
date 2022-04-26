using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Inventory System/Inventory Item")]
public class InventoryData : ScriptableObject
{
    public int ID;
    // code sorting number

    public string DisplayName;
    [TextArea(4, 4)]
    //The name the player sees in inventory

    public string Description;
    //a mini description of what an item is

    public Sprite Icon;
    //what it looks like in the inventory

    public int MaxStackSize;
    // how many of 1 item can be stacked in one place



}
