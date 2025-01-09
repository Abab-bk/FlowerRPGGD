using System.Collections.Generic;
using System.Linq;
using AcidUtilities;
using cfg;
using cfg.Stats;
using Godot;
using Game.Scripts.Base;
using Game.Scripts.Interactions;
using Game.Scripts.Items;
using Game.Scripts.Ui.InteractTip;
using Game.Scripts.Weapons;
using RPGCore.Combat;
using RPGCore.Inventories;
using RPGCore.Players;
using Vector2 = Godot.Vector2;

namespace Game.Scripts.Players;

public partial class Player : CharacterEntity
{
    [Export] private Area2D InteractionArea { get; set; }
    [Export] private Marker2D WeaponMarker { get; set; }

    public SizedInventory Inventory { get; private set; } = new(100);
    public PlayerEquipments Equipments { get; private set; } = new();
    public AbilityLoadout AbilityLoadout { get; private set; } = new();
    
    private readonly List<InteractTipPanel> _interactTipPanels = new();
    
    private HFSM ActionStateMachine { get; set; }
    
    public override void _Ready()
    {
        Global.Player = this;
        
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

        ActionStateMachine = HFSMUtils.TryConvert<HFSM>(GetNode<Node>("HFSM2"));
        if (ActionStateMachine == null)
            throw new System.Exception("Initialize Player state machine failed.");

        Equipments.Weapon.StoredItemChanged += item =>
        {
            if (item == null)
            {
                if (IsInstanceValid(WeaponMarker.GetChild(0))) return;
                if (WeaponMarker.GetChild(0) is not Weapon weapon) return;
                weapon.QueueFree();
                return;
            }

            var weaponEntity = WeaponFactory.Create(item);
            if (weaponEntity == null) return;
            
            WeaponMarker.AddChild(weaponEntity);
            weaponEntity.Config(true, CalculateAttack);
        };

        var timers = new Node();
        AddChild(timers);
        AbilityLoadout.Init(timers);
        
        EventBus.PlayerReady.Invoke();
    }

    private Attack CalculateAttack()
    {
        var attack = new Attack([
                new Damage(DamageType.Physical, 10f)
            ]
            );
        return attack;
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
                    ) * Stats.GetStat(StatType.MovementSpeed).Value;

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
        
        // because sprite is faced left... so x < mouse
        // AnimatedSprite2D.FlipH = GlobalPosition.X < GetGlobalMousePosition().X;
        Graphics.Scale = new Vector2(
            GlobalPosition.X < GetGlobalMousePosition().X ? 1 : -1,
            1
            );
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
    }

    public override void _UnhandledInput(InputEvent @event)
    {
        base._UnhandledInput(@event);
        if (!Equipments.Weapon.HasItem)
        {
            return;
        }

        var state = ActionStateMachine.GetCurrentState();
        if (state == null) return;

        if (state.GetName() != "Idle")
        {
            return;
        }

        if (@event.IsActionPressed("Attack"))
        {
            ActionStateMachine.SetTrigger("ToAttacking");
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
