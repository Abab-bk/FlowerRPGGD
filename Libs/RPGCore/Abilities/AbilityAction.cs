﻿namespace RPGCore.Abilities;

public class AbilityAction
{
    public AbilityActionType AbilityActionType { get; set; } = AbilityActionType.None;
    
    // == FireProjectile
    public string ProjectileName { get; set; } = "";
    public float MoveSpeed { get; set; }
    /// <summary>
    /// In degrees.
    /// </summary>
    public float Rotation { get; set; }
    public float Damage { get; set; }
    
    public void Activate(IAbility ability)
    {
        AbilityProcessor.Current.ProcessAbilityAction(this, ability);
        // TODO: implement
        // switch (AbilityActionType)
        // {
        //     case AbilityActionType.FireProjectile:
        //         break;
        // }
    }
}