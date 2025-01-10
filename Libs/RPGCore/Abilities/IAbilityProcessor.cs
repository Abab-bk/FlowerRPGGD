namespace RPGCore.Abilities;

public interface IAbilityProcessor
{
    public void ProcessAbilityAction(AbilityAction abilityAction, IAbility ability);
}