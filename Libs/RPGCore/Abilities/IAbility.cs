namespace RPGCore.Abilities;

public interface IAbility
{
    public AbilityClass AbilityClass { get; }
    public string Name { get; }
    public string IconName { get; }
    public IEnumerable<AbilityBehavior> Behaviors { get; }
    public IEnumerable<AbilityModifier> Modifiers { get; }
}