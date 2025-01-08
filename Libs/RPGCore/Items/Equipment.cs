using cfg.Items;
using RPGCore.Items.Affixes;

namespace RPGCore.Items;

public class Equipment(ItemTemplate template, IEnumerable<Affix> affixes) :
    AffixedItem(template, affixes)
{
    
}