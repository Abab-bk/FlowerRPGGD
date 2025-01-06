using cfg.Items;

namespace RPGCore.Items;

public class ItemSlot(IEnumerable<ItemType> types) : IItemSlot
{
    public event Action<IItem?> StoredItemChanged = delegate { };
    public IItem? StoredItem { get; private set; }

    public bool CanStore(ItemType itemType) => types.Contains(itemType);

    public bool Store(IItem item)
    {
        if (!CanStore(item.Template.ItemType)) return false;

        StoredItem = item;
        StoredItemChanged.Invoke(item);
        return true;
    }

    public IItem? Take()
    {
        var item = StoredItem;
        StoredItem = null;
        StoredItemChanged.Invoke(item);
        return item;
    }
}