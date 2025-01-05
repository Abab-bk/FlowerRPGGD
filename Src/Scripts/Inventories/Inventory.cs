using System;
using System.Collections.Generic;
using Game.Scripts.Items;

namespace Game.Scripts.Inventories;

public class Inventory
{
    public event Action<IITem> ItemAdded = delegate { };
    public event Action<IITem> ItemRemoved = delegate { };
    
    public readonly List<IITem> Items = new(); 
    
    public void AddItem(IITem item)
    {
        Items.Add(item);
        ItemAdded(item);
    }
    
    public void RemoveItem(IITem item)
    {
        Items.Remove(item);
        ItemRemoved(item);
    }
    
    public bool HasItem(IITem item) => Items.Contains(item);
}