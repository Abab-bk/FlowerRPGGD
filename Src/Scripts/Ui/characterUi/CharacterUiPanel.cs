using RPGCore.Inventories;
using RPGCore.Players;
using RPGCore.Stats;

namespace Game.Scripts.Ui.CharacterUi;

public partial class CharacterUiPanel : CharacterUi
{
    public CharacterStats CharacterStats;
    
    public void Init(
        CharacterStats characterStats,
        SizedInventory inventory,
        PlayerEquipments equipments
        )
    {
        CharacterStats = characterStats;
        
        S_InventoryUi.Instance.Init(inventory);
        S_CharacterEquipmentsUi.Instance.Init(equipments);

        S_InventoryUi.Instance.OnItemClicked += item =>
        {
            if (!equipments.TryEquip(item, out var oldItem)) return;
            inventory.RemoveItem(item);
            if (oldItem == null) return;
            inventory.AddItem(oldItem);
        };

        S_CharacterStatsUi.Instance.UpdateUi(CharacterStats);
        
        VisibilityChanged += () =>
        {
            S_CharacterStatsUi.Instance.UpdateUi(CharacterStats);
        };
    }
}
