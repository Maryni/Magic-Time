using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment",menuName = "Inventory/Equipment")]
public class Equipment : Item
{
    public EquipmentSlot equipSlot;

    public int armorMod;
    public int damageMod;

    public override void Use()
    {
        base.Use();
        EquipmentManager.instance.Equip(this);
        RemoveFromInventory();
    }
}
public enum EquipmentSlot {Head, Chest, Body, Legs, Hand, Bracers, Weapon, Feet, Necklace, Ring1, Ring2, Bag }
