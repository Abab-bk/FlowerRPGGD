using Godot;
using cfg.Characters;
using Game.Scripts.Base;

namespace Game.Scripts.Players;

public partial class Player : CharacterEntity
{
    [Export] private Area2D InteractionArea { get; set; }
    
    protected override void OnPhysicUpdated(State state, float delta)
    {
        base.OnPhysicUpdated(state, delta);
        switch (state.GetName())
        {
            case "Running":
                var x = Input.GetAxis(
                    "Left",
                    "Right"
                    ) * Stats.Speed.Value;

                if (IsOnFloor() && Input.IsActionJustPressed("Jump"))
                {
                    Velocity = Velocity with { Y = Velocity.Y - 300f };
                }

                Velocity = Velocity with { X = x };
                
                break;
            case "Idle":
                Velocity = Velocity with { X = 0f };
                break;
        }
        AnimatedSprite2D.FlipH = GlobalPosition.X > GetGlobalMousePosition().X;
        MoveAndSlide();
    }

    protected override void InitSprite()
    {
    }

    protected override void OnUpdated(State state, float delta)
    {
    }

    protected override void OnTransited(State from, State to)
    {
        switch (to.GetName())
        {
            case "Idle":
                AnimatedSprite2D.Play("Idle");
                break;
            case "Running":
                AnimatedSprite2D.Play("Running");
                break;
        }
    }
    
    public static Player Create(CharacterInfo characterInfo)
    {
        var player = GD.Load<PackedScene>("res://Scenes/Players/Player.tscn")
            .Instantiate<Player>();
        player.CharacterInfo = characterInfo;
        return player;
    }
}
