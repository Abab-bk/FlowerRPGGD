namespace RPGCore.Abilities;

#nullable disable
public static class AbilityProcessor
{
    public static IAbilityProcessor Current { get; private set; }
    
    public static void Init(IAbilityProcessor abilityProcessor)
    {
        Current = abilityProcessor;
    }
}