using Godot;
using Game.Scripts.Prefabs;

namespace Game.Scripts.Weapons;

public partial class Weapon : Node2D
{
    [Export] private HitBox _hitBox;
    
    public void Config(bool isPlayer) => _hitBox.Config(isPlayer);
}
