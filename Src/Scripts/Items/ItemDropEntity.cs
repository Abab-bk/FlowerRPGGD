using DataBase;
using Godot;

namespace Game.Scripts.Items;

public partial class ItemDropEntity : CharacterBody2D
{
    [Export] private Label _label;
    [Export] private Sprite2D _sprite;
    
    private Item _item;

    public override void _PhysicsProcess(double delta)
    {
        Velocity = Velocity with { Y = Velocity.Y + Data.Constants.Gravity * (float)delta };
        MoveAndSlide();
    }

    public static ItemDropEntity Create(Item item)
    {
        var scene = GD.Load<PackedScene>("res://Scenes/Items/ItemDropEntity.tscn");
        var instance = scene.Instantiate<ItemDropEntity>();
        instance._item = item;
        return instance;
    }

    public override void _Ready()
    {
        _label.Text = _item.Name;
    }

    public void GetDrop()
    {
        QueueFree();
    }
}
