using Godot;
using RPGCore.Players;

namespace Game.Scripts.Ui.AbilityLoadoutUi;

public partial class AbilityLoadoutUiPanel : AbilityLoadoutUi
{
    public AbilityLoadout Loadout { get; private set; }
    
    public void Init(AbilityLoadout loadout)
    {
        Loadout = loadout;
        Loadout.OnPrimaryChanged += S_PrimaryBtn.Instance.SetAbility;
        Loadout.OnSecondaryChanged += S_SecondaryBtn.Instance.SetAbility;
    }

    public override void _ShortcutInput(InputEvent @event)
    {
        base._ShortcutInput(@event);
        if (@event.IsActionPressed("PrimaryAbility"))
        {
            Loadout.Primary?.Activate();
        }
        if (@event.IsActionPressed("SecondaryAbility"))
        {
            Loadout.Secondary?.Activate();
        }
    }
}
