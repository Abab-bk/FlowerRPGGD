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
        
        InputManager.PrimaryAbility.OnPerformed += () => Loadout.Primary?.Activate();
        InputManager.SecondaryAbility.OnPerformed += () => Loadout.Secondary?.Activate();
    }
}
