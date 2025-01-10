using System;
using Game.Scripts.Projectiles;
using Godot;
using RPGCore.Abilities;
using RPGCore.Combat;

namespace Game.Scripts;

public class GAbilityProcessor : IAbilityProcessor
{
    public void ProcessAbilityAction(AbilityAction abilityAction, IAbility ability)
    {
        Vector2 targetPos;

        switch (ability.Behavior)
        {
            case AbilityBehavior.Aura:
                targetPos = Vector2.Zero;
                break;
            case AbilityBehavior.Point:
                targetPos = Global.World.GetGlobalMousePosition();
                break;
            case AbilityBehavior.Passive:
                targetPos = Vector2.Zero;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        
        switch (abilityAction.AbilityActionType)
        {
            case AbilityActionType.FireProjectile:
                var projectile = Projectile.Create(abilityAction.ProjectileName);
                Global.World.AddChild(projectile);
                projectile.GlobalPosition = Global.Player.GlobalPosition;
                projectile.Config(
                    true,
                    () => new Attack([new Damage(DamageType.Physical, 10f)]),
                    Global.Player.GetAngleTo(targetPos) +
                    Mathf.DegToRad(abilityAction.Rotation),
                    abilityAction.MoveSpeed
                    );
                break;
        }
    }
}