namespace RPGCore.Abilities;

public interface IAbility
{
    public event Action OnActivated;
    public event Action OnEnteredCooldown;
    
    public string Name { get; }
    public string IconName { get; }
    public float Cooldown { get; }
    public bool IsCooldown { get; }
    public AbilityClass AbilityClass { get; }
    public AbilityBehavior Behavior { get; }
    public IEnumerable<AbilityModifier> Modifiers { get; }
    
    public float GetCooldownRatio();
    public void Activate();
    public void InitToWorld(Godot.Timer timer);
    public void Clean();
}