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

    private HFSM _stateMachine;
    
    public override void _Ready()
    {
        base._Ready();
        _stateMachine = HFSMUtils.TryConvert<HFSM>(GetNode<Node>("HFSM"));
        if (_stateMachine == null)
            throw new System.Exception("Initialize Player state machine failed.");

        _stateMachine.Transited += OnTransited;
        _stateMachine.Updated += OnUpdated;
        _stateMachine.PhysicUpdated += OnPhysicUpdated;
        
        var processor = new DefaultAnimationProcessor();
        AnimatedSprite2D.SpriteFrames = processor.Process(
            $"res://Assets/Characters/{CharacterInfo.Sprite}.png"
            );
        AnimatedSprite2D.Animation = "Idle";
    }

    private void OnPhysicUpdated(State state, float delta)
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

    private void OnUpdated(State state, float delta)
    {
    }

    private void OnTransited(State from, State to)
    {
    }

    public override void _UnhandledInput(InputEvent @event)
    {
        base._UnhandledInput(@event);

        var state = _stateMachine.GetCurrentState();
        if (state == null) return;

        var dir = Input.GetVector(
            "Left",
            "Right",
            "Up",
            "Down"
            );
        
        switch (state.GetName())
        {
            case "Idle":
                if (dir != Vector2.Zero)
                    _stateMachine.SetTrigger("ToRunning");
                break;
            case "Running":
                if (dir == Vector2.Zero)
                    _stateMachine.SetTrigger("ToIdle");
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
