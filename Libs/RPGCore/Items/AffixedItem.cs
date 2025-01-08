using cfg.Items;
using RPGCore.Items.Affixes;
using RPGCore.Stats;

namespace RPGCore.Items;

public class AffixedItem(
    ItemTemplate template,
    IEnumerable<Affix> affixes
    ) : UniqueItem(template)
{
    public IEnumerable<Affix> Affixes { get; } = affixes;
    
    public void ApplyTo(CharacterStats stats)
    {
        foreach (var affix in Affixes)
        {
            stats
                .GetStat((int)affix.Template.TargetStatType)
                .AddModifier(affix.Modifier);
        }
    }
    
    public void RemoveFrom(CharacterStats stats)
    {
        foreach (var affix in Affixes)
        {
            stats
                .GetStat((int)affix.Template.TargetStatType)
                .RemoveModifier(affix.Modifier);
        }
    }
}