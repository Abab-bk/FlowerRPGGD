using Godot;

namespace Game.Scripts.Players;

public partial class PlayerController(Player player) : Node
{
    public Player Player { get; set; } = player;
    
    public override void _UnhandledInput(InputEvent @event)
    {
        base._UnhandledInput(@event);

        var state = Player.StateMachine.GetCurrentState();
        if (state == null) return;

        var dir = InputManager.MoveVector2Composite.ReadValue();
        
        switch (state.GetName())
        {
            case "Idle":
                if (dir != Vector2.Zero)
                    Player.StateMachine.SetTrigger("ToRunning");
                break;
            case "Running":
                if (dir == Vector2.Zero)
                    Player.StateMachine.SetTrigger("ToIdle");
                break;
        }
    }
}