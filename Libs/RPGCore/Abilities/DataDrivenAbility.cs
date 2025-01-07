namespace RPGCore.Abilities;

public class DataDrivenAbility : IAbility
{
    public string Name { get; set; } = string.Empty;
    public string IconName { get; set; } = string.Empty;
    
    public AbilityClass AbilityClass { get; set; } = AbilityClass.DataDriven;
    public IEnumerable<AbilityBehavior> Behaviors { get; set; } = new List<AbilityBehavior>();
    
    public IEnumerable<AbilityModifier> Modifiers { get; set; } = new List<AbilityModifier>();
    public IEnumerable<AbilityAction> OnActive { get; set; } = [];
}