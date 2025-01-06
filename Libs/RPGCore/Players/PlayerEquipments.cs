using cfg.Items;
using RPGCore.Items;

namespace RPGCore.Players;

public class PlayerEquipments
{
    public IItemSlot Head { get; private set; } = new ItemSlot([ItemType.Head]);
    public IItemSlot Body { get; private set; } = new ItemSlot([ItemType.Armor]);
    public IItemSlot Weapon { get; private set; } = new ItemSlot([ItemType.Sword]);
}