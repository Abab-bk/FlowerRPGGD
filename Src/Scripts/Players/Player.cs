using Godot;
using cfg.Characters;
using Game.Scripts.Base;

namespace Game.Scripts.Players;

public partial class Player : CharacterEntity
{
    protected override void OnPhysicUpdated(State state, float delta)
    {
        switch (state.GetName())
        {
            case "Running":
                Velocity = Input.GetVector(
                    "Left",
                    "Right",
                    "Up",
                    "Down"
                ) * CharacterInfo.Stats.Speed;
                MoveAndSlide();
                break;
        }
    }

    protected override void OnUpdated(State state, float delta)
    {
    }

    protected override void OnTransited(State from, State to)
    {
    }
    
    public static Player Create(CharacterInfo characterInfo, int id)
    {
        var player = GD.Load<PackedScene>("res://Scenes/Players/Player.tscn")
            .Instantiate<Player>();
        player.CharacterInfo = characterInfo;
        player.Id = id;
        return player;
    }
}
