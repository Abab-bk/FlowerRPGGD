using Game.Scripts.Items;
using RPGCore.Items;

namespace Game.Scripts.Ui.ItemCell;

public partial class ItemCellPanel : ItemCell
{
    public IItem Item { get; set; }
    
    public ItemCellPanel Config(IItem item)
    {
        Item = item;
        return this;
    }

    public void UpdateUi()
    {
    }
}
