using Godot;
using System.Collections.Generic;
using cfg.Characters;
using Game.AnimationProcessors;
using Game.Scripts.Classes;
using Game.Scripts.Interfaces;

namespace Game.Scripts.Players;

public partial class Player : CharacterBody2D, IGameEntity
{
    [Export] private AnimatedSprite2D AnimatedSprite2D { get; set; }
    
    public CharacterInfo CharacterInfo { get; private set; }
    public List<Component> Components { get; } = new List<Component>();

    public override void _Ready()
    {
        base._Ready();
        var processor = new DefaultAnimationProcessor();
        AnimatedSprite2D.SpriteFrames = processor.Process(
            $"res://Assets/Characters/{CharacterInfo.Sprite}.png"
            );
        AnimatedSprite2D.Animation = "Idle";
    }

    public override void _UnhandledInput(InputEvent @event)
    {
        base._UnhandledInput(@event);
        if (@event.IsActionPressed("Left"))
        {
        }
        if (@event.IsActionPressed("Right"))
        {
        }
        if (@event.IsActionPressed("Up"))
        {
        }
        if (@event.IsActionPressed("Down"))
        {
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
