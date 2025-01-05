using System.Collections.Generic;
using cfg.Characters;
using DataBase;
using Game.AnimationProcessors;
using Game.Scripts.Classes;
using Game.Scripts.Interfaces;
using Game.Scripts.Stats;
using Godot;

namespace Game.Scripts.Base;

public partial class CharacterEntity : CharacterBody2D, IGameEntity
{
    [Export] protected AnimatedSprite2D AnimatedSprite2D { get; set; }
    
    public List<Component> Components { get; } = new List<Component>();
    public CharacterInfo CharacterInfo { get; protected set; }
    public CharacterStats Stats { get; protected set; }
    
    public bool IsMultiplayer { get; protected set; }
    protected string Sprite { get; set; }
    
    public HFSM StateMachine { get; private set; }
    
    public override void _Ready()
    {
        base._Ready();
        
        StateMachine = HFSMUtils.TryConvert<HFSM>(GetNode<Node>("HFSM"));
        if (StateMachine == null)
            throw new System.Exception("Initialize Player state machine failed.");

        StateMachine.Transited += OnTransited;
        StateMachine.Updated += OnUpdated;
        StateMachine.PhysicUpdated += OnPhysicUpdated;

        Stats = new CharacterStats(CharacterInfo.Stats);
        
        InitSprite();
        
        TickSystem.OnTick += OnTick;
    }

    protected virtual void InitSprite()
    {
        var processor = new DefaultAnimationProcessor();
        AnimatedSprite2D.SpriteFrames = processor.Process(
            IsMultiplayer ? Sprite : $"res://Assets/Characters/{CharacterInfo.Sprite}.png"
        );
        AnimatedSprite2D.Animation = "Idle";
    }

    protected virtual void OnPhysicUpdated(State state, float delta)
    {
        Velocity = Velocity with { Y = Velocity.Y + Data.Constants.Gravity * delta };
    }

    protected virtual void OnUpdated(State state, float delta)
    {
    }

    protected virtual void OnTransited(State from, State to)
    {
    }
    
    protected virtual void OnTick(int tick)
    {
    }
}