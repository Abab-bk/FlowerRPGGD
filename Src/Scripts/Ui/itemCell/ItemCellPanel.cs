using System;
using DataBase.DataExtensions;
using Godot;
using RPGCore.Items;

namespace Game.Scripts.Ui.ItemCell;

public partial class ItemCellPanel : ItemCell
{
    public Action<IItem> OnItemClicked { get; set; }
    public IItem Item { get; set; }

    public override void OnCreateUi()
    {
        base.OnCreateUi();
        S_Button.Instance.Pressed += () => OnItemClicked?.Invoke(Item);
        
        S_Button.Instance.MouseEntered += () =>
        {
            if (Item == null) return;
            EventBus.ItemTooltipRequested?.Invoke(Item, GetGlobalMousePosition());
        };
        
        S_Button.Instance.MouseExited += EventBus.ItemTooltipCanceled;
    }

    public ItemCellPanel Config(IItem item)
    {
        Item = item;
        UpdateUi();
        return this;
    }

    public void UpdateUi()
    {
        S_Icon.Instance.Texture = GD.Load<Texture2D>(Item.Template.GetIconPath());
    }
}
