using Godot;
using RPGCore.Abilities;
using Timer = Godot.Timer;

namespace RPGCore.Players;

public class AbilityLoadout
{
    public event Action<IAbility?> OnPrimaryChanged = delegate { };
    public event Action<IAbility?> OnSecondaryChanged = delegate { };
    
    public IAbility? Primary { get; private set; }
    public IAbility? Secondary { get; private set; }

    private Node? _timers;
    
    public void Init(Node timers)
    {
        _timers = timers;
    }

    public void SetPrimary(IAbility? ability)
    {
        if (_timers == null) return;
        if (Primary != null) Primary.Clean();
        
        Primary = ability;

        if (Primary != null)
        {
            var timer = new Timer();
            _timers.AddChild(timer);
            Primary.InitToWorld(timer);
        }

        OnPrimaryChanged.Invoke(ability);
    }
    
    public void SetSecondary(IAbility? ability)
    {
        if (_timers == null) return;
        if (Secondary != null) Secondary.Clean();
        
        Secondary = ability;
        
        if (Secondary != null)
        {
            var timer = new Timer();
            _timers.AddChild(timer);
            Secondary.InitToWorld(timer);
        }
        
        OnSecondaryChanged.Invoke(ability);
    }
}