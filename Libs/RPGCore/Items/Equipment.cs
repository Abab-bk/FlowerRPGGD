using cfg.Items;
using RPGCore.Items.Affixes;

namespace RPGCore.Items;

public class Equipment : AffixedItem
{
    public Rarity Rarity;
    
    public Equipment(ItemTemplate template, IEnumerable<Affix> affixes) :
        base(template, affixes)
    {
        DisplayName = template.Name;
        Rarity = template.Rarity;
    }
}