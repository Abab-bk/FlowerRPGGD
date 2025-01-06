using System;
using Godot;
using Game.Scripts.Prefabs;
using RPGCore.Combat;

namespace Game.Scripts.Weapons;

public partial class Weapon : Node2D
{
    [Export] private HitBox _hitBox;
    
    public void Config(bool isPlayer, Func<Attack> getAttack) => _hitBox.Config(isPlayer, getAttack);
}
