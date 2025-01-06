using RPGCore.Inventories;

namespace Game.Scripts.Ui.CharacterUi;

public partial class CharacterUiPanel : CharacterUi
{
    public void Config(SizedInventory inventory)
    {
        S_InventoryUi.Instance.Config(inventory);
    }
}
