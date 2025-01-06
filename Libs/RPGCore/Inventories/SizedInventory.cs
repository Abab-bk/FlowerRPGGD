using RPGCore.Items;

namespace RPGCore.Inventories;

public class SizedInventory(int capacity) : IInventory
{
    public event Action<IItem> ItemAdded = delegate { };
    public event Action<IItem> ItemRemoved = delegate { };
    
    public List<IItem> Items { get; } = new ();
    public int Capacity { get; set; } = capacity;
    
    public bool AddItem(IItem item)
    {
        if (item is StackableItem stackableItem)
        {
            foreach (var item1 in Items)
            {
                if (item1.Template != stackableItem.Template) continue;
                if (item1 is not StackableItem stackableItem1) continue;
                stackableItem1.Add(stackableItem.Quantity);
                ItemAdded(item1);
                return true;
            }
        }

        if (item is not UniqueItem) return false;
        if (Items.Count > Capacity) return false;
        
        Items.Add(item);
        ItemAdded(item);
        return true;
    }

    public bool RemoveItem(IItem item)
    {
        if (item is StackableItem stackableItem)
        {
            foreach (var item1 in Items)
            {
                if (item1.Template != stackableItem.Template) continue;
                if (item1 is not StackableItem stackableItem1) continue;
                var removedItem = stackableItem1.Take(stackableItem.Quantity);
                if (stackableItem1.Quantity == 0) Items.Remove(item1);
                ItemRemoved(item1);
                return true;
            }
        }

        if (item is not UniqueItem) return false;
        Items.Remove(item);
        ItemRemoved(item);
        return true;
    }
}