using System.Collections.Generic;
using System.Linq;
using AcidUtilities;
using Godot;
using cfg.Characters;
using Game.Scripts.Base;
using Game.Scripts.Interactions;
using Game.Scripts.Ui.InteractTip;

namespace Game.Scripts.Players;

public partial class Player : CharacterEntity
{
    [Export] private Area2D InteractionArea { get; set; }

    private readonly List<InteractTipPanel> _interactTipPanels = new();
    
    public override void _Ready()
    {
        base._Ready();
        InteractionArea.AreaEntered += area =>
        {
            if (area is not IInteractable interactable) return;
            var panel = InteractTipPanel.Create(interactable);
            _interactTipPanels.Insert(0, panel);
            Global.World.AddChild(panel);
            panel.RSetGlobalPosition(area.GlobalPosition);
        };
        InteractionArea.AreaExited += area =>
        {
            if (area is not IInteractable interactable) return;
            
            foreach (var panel in _interactTipPanels)
            {
                if (panel.Interactable != interactable) continue;
                panel.QueueFree();
                _interactTipPanels.Remove(panel);
                break;
            }
        };
    }
    
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
    
    public override void _ShortcutInput(InputEvent @event)
    {
        if (
            @event.IsActionPressed("Interact") &&
            _interactTipPanels.Count > 0
            )
        {
            _interactTipPanels.First().Interactable.Interact();
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
