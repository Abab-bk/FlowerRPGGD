using Game.Scripts.Enums;
using Godot;

namespace Game.Scripts.Prefabs;

[GlobalClass]
public partial class HitBox : Area2D
{
    public void Config(bool isPlayer)
    {
        CollisionLayer = 0;
        CollisionMask = 0;
        
        if (isPlayer)
        {
            CallDeferred(
                CollisionObject2D.MethodName.SetCollisionLayerValue,
                (int)CollisionLayerName.PlayerHitBox,
                true
                );
            CallDeferred(
                CollisionObject2D.MethodName.SetCollisionMaskValue,
                (int)CollisionLayerName.MobHurtBox,
                true
                );
        }
        else
        {
            CallDeferred(
                CollisionObject2D.MethodName.SetCollisionLayerValue,
                (int)CollisionLayerName.MobHitBox,
                true
            );
            CallDeferred(
                CollisionObject2D.MethodName.SetCollisionMaskValue,
                (int)CollisionLayerName.PlayerHurtBox,
                true
            );
        }
    }

    public static HitBox Create() =>
        GD.Load<PackedScene>("res://Scenes/Prefabs/HitBox.tscn").Instantiate<HitBox>();
}