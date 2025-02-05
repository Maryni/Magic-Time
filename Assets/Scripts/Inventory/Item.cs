﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Item",menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;
    public float weight;

    public virtual void Use()
    {
        Debug.Log("Using " + name);
    }
    public void RemoveFromInventory()
    {
        Inventory.instance.Remove(this);
    }
}
