using RPGCore.Items;

namespace RPGCore.Inventories;

public interface IInventory
{
    List<IItem> Items { get; }
    bool AddItem(IItem item);
    bool RemoveItem(IItem item);
}