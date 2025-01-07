namespace RPGCore.Abilities;

public class DataDrivenAbility : IAbility
{
    public event Action OnActivated = delegate { };
    public event Action OnEnteredCooldown = delegate { };
    
    public AbilityClass AbilityClass { get; set; } = AbilityClass.DataDriven;
    
    public string Name { get; set; } = string.Empty;
    public string IconName { get; set; } = string.Empty;
    public float Cooldown { get; set; } = 0f;
    
    public IEnumerable<AbilityBehavior> Behaviors { get; set; } = new List<AbilityBehavior>();
    public IEnumerable<AbilityModifier> Modifiers { get; set; } = new List<AbilityModifier>();
    public IEnumerable<AbilityAction> OnActive { get; set; } = [];

    public bool IsCooldown { get; private set; }
    
    private Godot.Timer? _timer;

    public float GetCooldownRatio()
    {
        if (_timer == null) return 0f;
        return (float)_timer.TimeLeft / Cooldown;
    }

    public void InitToWorld(Godot.Timer timer)
    {
        _timer = timer;
        _timer.Timeout += OnTimerTimeout;
        _timer.OneShot = true;
        _timer.WaitTime = Cooldown;
    }

    public void Clean()
    {
        if (_timer == null) return;
        _timer.Timeout -= OnTimerTimeout;
        _timer.QueueFree();
    }

    private void OnTimerTimeout()
    {
        IsCooldown = false;
    }

    public void Activate()
    {
        if (IsCooldown) return;
        
        foreach (var action in OnActive)
        {
            action.Activate();
        }
        
        OnActivated.Invoke();

        IsCooldown = true;
        OnEnteredCooldown.Invoke();
        _timer?.Start(Cooldown);
    }
}