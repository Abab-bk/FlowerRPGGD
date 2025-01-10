using FlowerInputSystem;
using FlowerInputSystem.Actions;
using Godot;

namespace Game.Scripts;

public static class InputManager
{
    public static InputBinding MoveUp = new ()
    {
        Key = Key.W
    };

    public static InputBinding MoveDown = new()
    {
        Key = Key.S
    };

    public static InputBinding MoveLeft = new()
    {
        Key = Key.A
    };

    public static InputBinding MoveRight = new()
    {
        Key = Key.D
    };

    public static readonly InputAction Move = new()
    {
        Name = "Move",
        Vector2Composite = new Vector2Composite(
            ref MoveDown,
            ref MoveRight,
            ref MoveUp,
            ref MoveLeft
        )
    };

    public static readonly InputAction CharacterUi = new()
    {
        Name = "CharacterUi",
        Bindings = [new InputBinding
        {
            Key = Key.Tab
        }]
    };

    public static readonly InputAction PrimaryAbility = new()
    {
        Name = "PrimaryAbility",
        Bindings = [new InputBinding
        {
            MouseButton = MouseButton.Left
        }]
    };
    
    public static readonly InputAction SecondaryAbility = new()
    {
        Name = "SecondaryAbility",
        Bindings = [new InputBinding
        {
            MouseButton = MouseButton.Right
        }]
    };

    public static readonly InputAction Interact = new()
    {
        Name = "Interact",
        Bindings = [new InputBinding
        {
            Key = Key.E
        }]
    };
    
    public static Vector2Composite MoveVector2Composite => Move.Vector2Composite;

    public static readonly InputAction Pause = new()
    {
        Name = "Pause",
        Bindings = [new InputBinding
        {
            Key = Key.Escape
        }]
    };
    
    public static void Init()
    {
        var playerMap = new ActionMap(
            [
                Move,
                CharacterUi,
                PrimaryAbility,
                SecondaryAbility,
                Interact,
                Pause
            ]
        )
        {
            Name = "PlayerMap"
        };
        
        InputSystem.Initialize([playerMap]);
    }

    public static void Update() => InputSystem.Update();
}