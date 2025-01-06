using DataBase.DataExtensions;
using Game.Scripts.Weapons;
using Godot;
using RPGCore.Items;

namespace Game.Scripts.Items;

public class WeaponFactory
{
    public static Weapon Create(IItem item)
    {
        if (!item.Template.IsWeapon()) return null;
        var scene = GD.Load<PackedScene>("res://Scenes/Weapons/SimpleSword.tscn");
        var instance = scene.Instantiate<Weapon>();
        return instance;
    }
}