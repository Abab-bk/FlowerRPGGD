using Game.Scripts.Projectiles;
using RPGCore.Abilities;
using RPGCore.Combat;

namespace Game.Scripts;

public class GAbilityProcessor : IAbilityProcessor
{
    public void ProcessAbilityAction(AbilityAction abilityAction)
    {
        switch (abilityAction.AbilityActionType)
        {
            case AbilityActionType.FireProjectile:
                var projectile = Projectile.Create(abilityAction.ProjectileName);
                Global.World.AddChild(projectile);
                projectile.GlobalPosition = Global.Player.GlobalPosition;
                projectile.Config(
                    true,
                    () => new Attack([new Damage(DamageType.Physical, 10f)]),
                    abilityAction.Rotation,
                    abilityAction.MoveSpeed
                    );
                break;
        }
    }
}