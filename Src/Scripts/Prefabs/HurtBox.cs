using Game.Scripts.Enums;
using Godot;

namespace Game.Scripts.Prefabs;

[GlobalClass]
public partial class HurtBox : Area2D
{
    public void Config(bool isPlayer)
    {
        CollisionLayer = 0;
        CollisionMask = 0;
        
        if (isPlayer)
        {
            CallDeferred(
                CollisionObject2D.MethodName.SetCollisionLayerValue,
                (int)CollisionLayerName.PlayerHurtBox
            );
            CallDeferred(
                CollisionObject2D.MethodName.SetCollisionMaskValue,
                (int)CollisionLayerName.MobHitBox
            );
        }
        else
        {
            CallDeferred(
                CollisionObject2D.MethodName.SetCollisionLayerValue,
                (int)CollisionLayerName.MobHurtBox
            );
            CallDeferred(
                CollisionObject2D.MethodName.SetCollisionMaskValue,
                (int)CollisionLayerName.PlayerHitBox
            );
        }
    }
    
    public static HurtBox Create() =>
        GD.Load<PackedScene>("res://Scenes/Prefabs/HurtBox.tscn").Instantiate<HurtBox>();
}