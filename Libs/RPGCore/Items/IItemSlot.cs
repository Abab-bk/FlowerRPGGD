using cfg.Items;

namespace RPGCore.Items;

public interface IItemSlot
{
    public event Action<IItem?> StoredItemChanged;
    
    IItem? StoredItem { get; }
    
    public bool HasItem => StoredItem != null;
    public bool CanStore(ItemType itemType);
    public bool Store(IItem item);
    public IItem? Take();
}