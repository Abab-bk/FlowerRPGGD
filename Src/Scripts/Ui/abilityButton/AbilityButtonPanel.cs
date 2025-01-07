using Game.Scripts.Extensions;
using Godot;
using RPGCore.Abilities;

namespace Game.Scripts.Ui.AbilityButton;

public partial class AbilityButtonPanel : AbilityButton
{
    [Export] public string Key { get; private set; }
    [Export] private string DisplayName { get; set; }
    
    public IAbility Ability { get; private set; }

    public void SetAbility(IAbility ability)
    {
        Ability = ability;
        S_Icon.Instance.Texture = GD.Load<Texture2D>(ability.GetIconPath());
    }

    public override void Process(float delta)
    {
        base.Process(delta);
        if (Ability == null || !Ability.IsCooldown) return;
        S_CooldownProgress.Instance.Value = Ability.GetCooldownRatio() * 100f;
    }

    public override void _Ready()
    {
        S_KeyLabel.Instance.Text = DisplayName;
    }
}
