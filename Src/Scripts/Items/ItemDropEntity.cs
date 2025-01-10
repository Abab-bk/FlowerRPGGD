using Godot;
using RPGCore.Items;

namespace Game.Scripts.Items;

public partial class ItemDropEntity : Node2D
{
    [Export] private Label _label;
    [Export] private Sprite2D _sprite;
    
    private IItem _item;
    
    public static ItemDropEntity Create(IItem item)
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
