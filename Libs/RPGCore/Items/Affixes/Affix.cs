using cfg.Items;
using FlowerRpg.Stats.Modifiers;
using RPGCore.Stats;
using RPGCore.Utils;

namespace RPGCore.Items.Affixes;

public class Affix
{
    public AffixTemplate Template { get; private set; }
    public float Value { get; private set; }
    public Modifier Modifier { get; private set; }
    
    public Affix(AffixTemplate template, CharacterStats stats)
    {
        Value = template.GetAffixValue(stats);
        Modifier = new Modifier(Value, template.ValueType, this);
        Template = template;
    }

    public string GetDescription()
    {
        var valueTypeStr = Template.ValueType == ModifierType.Flat ? "" : "%";
        
        return $"{Template.TargetStatType.ToString()} + {Value.ToString("F0")}{valueTypeStr} {Template.TargetStatType.ToString()}";
    }
}