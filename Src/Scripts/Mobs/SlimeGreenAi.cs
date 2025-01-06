using Godot;

namespace Game.Scripts.Mobs;

public partial class SlimeGreenAi : MobAi
{
    protected override void OnPhysicUpdated(State state, float delta)
    {
        base.OnPhysicUpdated(state, delta);

        switch (state.GetName())
        {
            case "Idle":
                if (Global.Player.GlobalPosition.DistanceTo(Mob.GlobalPosition) > 200)
                    StateMachine.SetTrigger("ToRunning");
                Mob.Velocity = Mob.Velocity with { X = 0f };
                break;
            case "Running":
                if (Global.Player.GlobalPosition.DistanceTo(Mob.GlobalPosition) < 200)
                    StateMachine.SetTrigger("ToIdle");
                Mob.MoveToPlayer();
                break;
        }
        Mob.MoveAndSlide();
    }
}
