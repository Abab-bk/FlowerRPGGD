using RPGCore.Abilities;

namespace Game.Scripts.Extensions;

public static class IAbilityExtension
{
    public static string GetIconPath(this IAbility ability)
    {
        return $"res://Assets/AbilityIcons/{ability.Name}.png";
    }
}