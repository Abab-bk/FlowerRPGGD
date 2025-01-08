using AcidUtilities;
using Godot;
using RPGCore.Items;

namespace Game.Scripts.Ui.ItemTooltip;

public partial class ItemTooltipPanel : ItemTooltip
{
    public void UpdateTooltip(IItem item)
    {
        S_Name.Instance.Text = item.Name;
        S_Rarity.Instance.Text = item.Template.Rarity.ToString();

        if (item is AffixedItem affixedItem)
        {
            foreach (var affix in affixedItem.Affixes)
            {
                S_BaseStats.AddChild(new Label
                {
                    Text = affix.GetDescription()
                });
            }
        }
    }

    public void Clean()
    {
        S_BaseStats.Instance.RemoveAllChildren();
    }
}
