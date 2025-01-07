using System;
using DsUi;
using Game.Scripts.Ui.ItemCell;
using RPGCore.Inventories;
using RPGCore.Items;

namespace Game.Scripts.Ui.InventoryUi;

public partial class InventoryUiPanel : InventoryUi
{
    public SizedInventory Inventory { get; private set; }
    public Action<IItem> OnItemClicked { get; set; }
    
    public InventoryUiPanel Init(
        SizedInventory inventory,
        Action<IItem> onItemClicked = null
        )
    {
        Inventory = inventory;
        
        Inventory.ItemAdded += _ => UpdateUi();
        Inventory.ItemRemoved += _ => UpdateUi();

        OnItemClicked = onItemClicked;
        
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
            itemCell.OnItemClicked += item1 => OnItemClicked?.Invoke(item1);
            // itemCell.UpdateUi();
        }
    }
}
