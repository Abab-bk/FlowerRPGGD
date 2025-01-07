using Godot;
using System;
using Game.Scripts.Prefabs;
using RPGCore.Combat;

namespace Game.Scripts.Projectiles;

public partial class Projectile : Node2D
{
    [Export] public HitBox HitBox { get; private set; }
    [Export] private Node2D Graphics { get; set; }

    private float _rotation;
    private float _moveSpeed;

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

        HitBox.OnHit += OnHit;
        
        Rotation = Mathf.DegToRad(rotation);
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

        Position += Vector2.Right.Rotated(Rotation) * _moveSpeed * (float)delta;
    }

    public static Projectile Create(string projectileName)
    {
        return GD
            .Load<PackedScene>($"res://Scenes/Projectiles/{projectileName}.tscn")
            .Instantiate<Projectile>();
    }
}
