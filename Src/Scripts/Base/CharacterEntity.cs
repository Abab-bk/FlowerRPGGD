using System.Collections.Generic;
using cfg.Characters;
using Game.AnimationProcessors;
using Game.Scripts.Classes;
using Game.Scripts.Interfaces;
using Godot;

namespace Game.Scripts.Base;

public partial class CharacterEntity : CharacterBody2D, IGameEntity
{
    [Export] private AnimatedSprite2D AnimatedSprite2D { get; set; }
    
    public List<Component> Components { get; } = new List<Component>();
    public int Id { get; protected set; }
    public CharacterInfo CharacterInfo { get; protected set; }
    
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
        
        var processor = new DefaultAnimationProcessor();
        AnimatedSprite2D.SpriteFrames = processor.Process(
            IsMultiplayer ? Sprite : $"res://Assets/Characters/{CharacterInfo.Sprite}.png"
        );
        AnimatedSprite2D.Animation = "Idle";
        
        TickSystem.OnTick += OnTick;
    }
    
    protected virtual void OnPhysicUpdated(State state, float delta)
    {
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