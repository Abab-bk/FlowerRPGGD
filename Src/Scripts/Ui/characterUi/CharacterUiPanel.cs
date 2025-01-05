using Game.Scripts.Inventories;

namespace Game.Scripts.Ui.CharacterUi;

public partial class CharacterUiPanel : CharacterUi
{
    public void Config(Inventory inventory)
    {
        S_InventoryUi.Instance.Config(inventory);
    }
}
