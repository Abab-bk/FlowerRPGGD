using cfg.Items;
using RandomExtensions;
using RPGCore.Stats;

namespace RPGCore.Utils;

public static class AffixExtension
{
    public static float GetAffixValue(this AffixTemplate affix, CharacterStats stats)
    {
        return RandomEx.Shared.NextFloat(affix.ValueRange[0], affix.ValueRange[1]);
    }
}