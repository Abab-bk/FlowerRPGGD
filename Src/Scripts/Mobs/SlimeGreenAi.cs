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
                if (Global.Player.GlobalPosition.DistanceTo(Mob.GlobalPosition) > 100)
                    StateMachine.SetTrigger("ToRunning");
                Mob.StopMove();
                break;
            case "Running":
                if (Global.Player.GlobalPosition.DistanceTo(Mob.GlobalPosition) < 100)
                    StateMachine.SetTrigger("ToIdle");
                Mob.MoveToPlayer();
                break;
        }
        Mob.MoveAndSlide();
    }
}
