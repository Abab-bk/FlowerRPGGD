using cfg.Items;
using RPGCore.Items;

namespace RPGCore.Players;

public class PlayerEquipments
{
    public IItemSlot Helmet { get; private set; } = new ItemSlot([ItemType.Helmet]);
    public IItemSlot Chest { get; private set; } = new ItemSlot([ItemType.Chest]);
    public IItemSlot Gloves { get; private set; } = new ItemSlot([ItemType.Gloves]);
    public IItemSlot Pants { get; private set; } = new ItemSlot([ItemType.Pants]);
    public IItemSlot Boots { get; private set; } = new ItemSlot([ItemType.Boots]);
    public IItemSlot Weapon { get; private set; } = new ItemSlot(
        [
            ItemType.Sword,
            ItemType.Axe,
            ItemType.Dagger,
            ItemType.Wand,
            ItemType.Staff,
            ItemType.Bow,
            ItemType.Shield,
            ItemType.HugeSword,
            ItemType.HugeAxe
        ]
        );

    public bool TryEquip(IItem item, out IItem? oldItem)
    {
        if (Weapon.CanStore(item.Template.ItemType))
        {
            oldItem = Weapon.StoredItem;
            Weapon.Store(item);
            return true;
        }

        oldItem = null;
        return false;
    }
}