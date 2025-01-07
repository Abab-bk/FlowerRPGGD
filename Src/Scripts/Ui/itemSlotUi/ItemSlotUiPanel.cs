using DataBase.DataExtensions;
using Godot;
using RPGCore.Items;

namespace Game.Scripts.Ui.ItemSlotUi;

public partial class ItemSlotUiPanel : ItemSlotUi
{
    public IItemSlot ItemSlot { get; private set; }
    
    public void Init(IItemSlot slot)
    {
        ItemSlot = slot;
        ItemSlot.StoredItemChanged += item =>
        {
            S_Icon.Instance.Texture = GD.Load<Texture2D>(item.Template.GetIconPath());
        };
    }
}
