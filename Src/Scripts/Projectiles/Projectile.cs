using Godot;
using System;
using Game.Scripts.Prefabs;
using RPGCore.Combat;

namespace Game.Scripts.Projectiles;

public partial class Projectile : Node2D
{
    [Export] private VisibleOnScreenNotifier2D VisibleNotifier { get; set; }
    [Export] public HitBox HitBox { get; private set; }
    [Export] private Node2D Graphics { get; set; }

    private float _rotation;
    private float _moveSpeed;

    public override void _Ready()
    {
        VisibleNotifier.ScreenExited += Destroy;
    }

    public void Config(
        bool isPlayer,
        Func<Attack> getAttack,
        float rotation,
        float moveSpeed
    )
    {
        HitBox.Config(isPlayer, getAttack);
        _rotation = rotation;
        _moveSpeed = moveSpeed;

        Rotation = _rotation;
        
        HitBox.OnHit += OnHit;
        
        // Rotation = Mathf.DegToRad(rotation);
    }

    protected virtual void OnHit()
    {
        Destroy();
    }

    protected virtual void Destroy()
    {
        QueueFree();
    }

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
        Position += Vector2.Right.Rotated(_rotation) * _moveSpeed * (float)delta;
    }

    public static Projectile Create(string projectileName)
    {
        return GD
            .Load<PackedScene>($"res://Scenes/Projectiles/{projectileName}.tscn")
            .Instantiate<Projectile>();
    }
}
