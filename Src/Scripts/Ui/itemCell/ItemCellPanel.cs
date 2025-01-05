using Game.Scripts.Items;

namespace Game.Scripts.Ui.ItemCell;

public partial class ItemCellPanel : ItemCell
{
    public IITem Item { get; set; }
    
    public ItemCellPanel Config(IITem item)
    {
        Item = item;
        return this;
    }

    public void UpdateUi()
    {
    }
}
