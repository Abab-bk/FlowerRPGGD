using RPGCore.Inventories;
using RPGCore.Players;

namespace Game.Scripts.Ui.CharacterUi;

public partial class CharacterUiPanel : CharacterUi
{
    public void Init(SizedInventory inventory, PlayerEquipments equipments)
    {
        S_InventoryUi.Instance.Init(inventory);
        S_CharacterEquipmentsUi.Instance.Init(equipments);

        S_InventoryUi.Instance.OnItemClicked += item =>
        {
            if (!equipments.TryEquip(item, out var oldItem)) return;
            inventory.RemoveItem(item);
            if (oldItem == null) return;
            inventory.AddItem(oldItem);
        };
    }
}
