using DsUi;
using Game.Scripts.Ui.ItemCell;
using RPGCore.Inventories;

namespace Game.Scripts.Ui.InventoryUi;

public partial class InventoryUiPanel : InventoryUi
{
    public SizedInventory Inventory { get; private set; }
    
    public InventoryUiPanel Config(SizedInventory inventory)
    {
        Inventory = inventory;
        
        Inventory.ItemAdded += _ => UpdateUi();
        Inventory.ItemRemoved += _ => UpdateUi();
        
        return this;
    }

    public void UpdateUi()
    {
        foreach (var child in S_Items.Instance.GetChildren())
        {
            child.QueueFree();
        }
        
        foreach (var item in Inventory.Items)
        {
            var itemCell = S_Items.OpenNestedUi<ItemCellPanel>(UiManager.UiName.ItemCell);
            itemCell.Config(item);
            itemCell.Show();
            itemCell.UpdateUi();
        }
    }
}
